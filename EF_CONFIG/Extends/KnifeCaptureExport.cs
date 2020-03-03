using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_CONFIG.Models;
using OfficeOpenXml.Packaging;
using OfficeOpenXml.Style;
using EF_CONFIG.Data;
using EF_CONFIG.Base;
using EF_CONFIG.Extends;
using OfficeOpenXml;
using System.IO;
using System.Drawing;
using EF_CONFIG.DataTransform;

namespace EF_CONFIG.Extends
{
    public static class KnifeCaptureExport
    {
        private static KC_ImplementBase KC_ImplementBase = new KC_ImplementBase(new DataContext());
        private static string GetCurrentEditingFilePath(string StorageFolder)
        {
            try
            {
                string knife_capture_path = $"{StorageFolder}/__KNIFE_CAPTURE__";
                string[] folders = Directory.GetDirectories(StorageFolder);
                if (!folders.Contains(knife_capture_path))
                    Directory.CreateDirectory(knife_capture_path);

                DateTime FirstDate = SysExtends.FirstDayOfWeek(DateTime.Now);

                string CurrentMonthFolder = FirstDate.ToString("MM_yyyy");

                string[] MonthFolders = Directory.GetDirectories(knife_capture_path);

                string MonthFolderPath = $"{knife_capture_path}/{CurrentMonthFolder}";
                if (!MonthFolders.Contains(CurrentMonthFolder))
                    Directory.CreateDirectory(MonthFolderPath);

                string[] ExportedFilePaths = Directory.GetFiles(MonthFolderPath, "*.xlsx");

                //checking file already 
                string FileName = FirstDate.ToString("ddd_dd_MM_yy");

                //full file path
                string FullFilePath = $"{MonthFolderPath}/{FileName}.xlsx";

                if (!ExportedFilePaths.Contains(FullFilePath))
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        FileInfo NewFile = new FileInfo(FullFilePath);
                        package.Workbook.Worksheets.Add("HELLO WORLD");

                        package.SaveAs(NewFile);
                    }
                }

                return FullFilePath;
            }
            catch { return null; }
        }
        // Return current editing file
        public static string ExportToExcel_KC_Device(KC_Device KC_Device, string StorageFolder)
        {
            // get all post file on date
            var records = KC_ImplementBase.Get_KC_PostRecord(KC_Device, DateTime.Now);

            if (records == null)
            {
                records = KC_ImplementBase.Get_KC_PostRecord(KC_Device);
                if (records == null)
                    return null;
            }

            // get last post file
            var last_record = records.OrderByDescending(i => i.Id).FirstOrDefault();
            if (last_record == null) return null;

            var machines = KC_ImplementBase.Get_KC_DisMachines(last_record);

            if (machines == null)
                return null;

            string FullFilePath = GetCurrentEditingFilePath(StorageFolder);
            // Initialize CurrentEditFile
            FileInfo CurrentEditFile = new FileInfo(FullFilePath);

            using (ExcelPackage package = new ExcelPackage(CurrentEditFile))
            {
                int SheetIndex = 0;

                while (package.Workbook.Worksheets.Count() < machines.Count)
                {
                    package.Workbook.Worksheets.Add(Guid.NewGuid().ToString());
                }

                foreach (var item in machines)
                {
                    var autoCutMachine = KC_ImplementBase.Get_AutoCutMachine((int)item.AutoCutMachineId);

                    if (autoCutMachine == null)
                        continue;

                    SheetIndex++;

                    string SheetName = $"{autoCutMachine.MachineName}";

                    package.Workbook.Worksheets[SheetIndex].Name = SheetName;

                    ExcelWorksheet CurrentEditSheet = package.Workbook.Worksheets[SheetIndex];

                    ExportToExcel_KC_Machine(autoCutMachine, CurrentEditSheet);
                }

                package.Save();
            }

            return FullFilePath;
        }
        public static void ExportToExcel_KC_Machine(AutoCutMachine Machine, ExcelWorksheet CurrentSheet)
        {
            var knife_captures = KC_ImplementBase.Get_KnifeCaptureTrackingsOnWeek(Machine);
            if (knife_captures == null)
                return;
            string[] Header = new string[] { "Tổng/STT", "Thời gian", "Loại dao", "Đầu dao", "Tên dao", "Hiện tại" };

            int beginColumn = 1;
            int beginRow = 1;
            //create excel header
            for (int i = beginColumn; i <= Header.Length; i++)
            {
                CurrentSheet.Cells[beginRow, i].Value = Header[i - 1];
                CurrentSheet.Cells[beginRow, i].Style.Font.Bold = true;
                CurrentSheet.Cells[beginRow, i].Style.Border.BorderAround(ExcelBorderStyle.Medium);
            }

            ExcelRange HeaderRow = CurrentSheet.Cells[beginRow, beginColumn, beginRow, beginColumn + 4];
            HeaderRow.Style.Fill.PatternType = ExcelFillStyle.Solid;
            HeaderRow.Style.Fill.BackgroundColor.SetColor(Color.Yellow);
            HeaderRow.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            HeaderRow.Style.VerticalAlignment = ExcelVerticalAlignment.Center;

            HeaderRow.Style.Border.BorderAround(ExcelBorderStyle.Medium);

            int Total = 0;
            foreach (var item in knife_captures)
            {
                Total++;

                ExcelRange CurrentRow = CurrentSheet.Cells[beginRow + Total, beginColumn, beginRow + Total, beginColumn + 4];

                CurrentRow.Style.Fill.PatternType = ExcelFillStyle.Solid;

                if (item.KnifeType == 0)
                    CurrentRow.Style.Fill.BackgroundColor.SetColor(Color.Silver);

                if (item.KnifeType == 1)
                    CurrentRow.Style.Fill.BackgroundColor.SetColor(Color.LightBlue);

                int CurrentRowIndex = beginRow + Total;

                ExcelRange TotalCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 0];
                ExcelRange TimeCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 1];
                ExcelRange TypeCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 2];
                ExcelRange PosCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 3];
                ExcelRange KnifeNameCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 4];
                ExcelRange LocalCell = CurrentSheet.Cells[CurrentRowIndex, beginColumn + 5];

                TotalCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                TimeCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                TypeCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                PosCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                KnifeNameCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);
                LocalCell.Style.Border.BorderAround(ExcelBorderStyle.Dashed);

                if (item.KnifeHeadPos == 0)
                {
                    PosCell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    PosCell.Style.Fill.BackgroundColor.SetColor(Color.LightGreen);
                }

                if (item.KnifeHeadPos == 1)
                {
                    PosCell.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    PosCell.Style.Fill.BackgroundColor.SetColor(Color.LightYellow);
                }

                var knife = ComponentBase.Get_Knife(item.LocalKnifeId);
                string knife_name = knife != null ? knife.ComponentCode : string.Empty;

                TotalCell.Value = Total;
                TimeCell.Value = item.UpdateTime.ToString("ddd, dd/MM/yy, hh:ss tt");
                TypeCell.Value = item.KType;
                PosCell.Value = item.KPosition;
                KnifeNameCell.Value = knife_name;
                LocalCell.Value = item.LocalValue;
            }

            ExcelRange CurrentTable = CurrentSheet.Cells[beginRow, beginColumn, beginRow + Total, beginColumn + 5];
            CurrentTable.Style.Border.BorderAround(ExcelBorderStyle.Medium);

            CurrentSheet.Cells.Style.WrapText = true;
            CurrentSheet.Column(beginColumn).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            CurrentSheet.Column(beginColumn + 5).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

            CurrentSheet.Column(beginColumn + 1).Width = 30;
            CurrentSheet.Column(beginColumn + 2).Width = 20;
            CurrentSheet.Column(beginColumn + 3).Width = 20;
            CurrentSheet.Column(beginColumn + 4).Width = 20;
        }
    }
}
