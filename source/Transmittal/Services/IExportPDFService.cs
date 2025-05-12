using Autodesk.Revit.DB;

namespace Transmittal.Services;
internal interface IExportPDFService
{
#if REVIT2022_OR_GREATER
    /// <summary>
    /// PDF exported using the Revit 2022+ method
    /// </summary>
    /// <param name="exportFileName">输出的pdf文件名称</param>
    /// <param name="exportDocument">模型</param>
    /// <param name="views">图纸视图集合</param>
    /// <param name="pdfExportOptions">pdf输出选项</param>
    /// <param name="RecordError">是否日志记录错误 默认true</param>
    /// <returns>full path to the exported file</returns>
    string ExportPDF(string exportFileName, Document exportDocument, ViewSet views, PDFExportOptions pdfExportOptions, bool RecordError = true);
#endif

    /// <summary>
    /// PDF printed using PDF Printer   
    /// </summary>
    /// <param name="exportFileName">输出的pdf文件名称</param>
    /// <param name="exportDocument">模型</param>
    /// <param name="views">图纸视图集合</param>
    /// <param name="pdfExportOptions">pdf输出选项</param>
    /// <param name="RecordError">是否日志记录错误 默认true</param>
    /// <returns>full path to the printed file</returns>
    string PrintPDF(string exportFileName, Document exportDocument, ViewSet views, PDFExportOptions pdfExportOptions, bool RecordError = true);
}
