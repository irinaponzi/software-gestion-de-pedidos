using iTextSharp.text;
using iTextSharp.text.pdf;
using pedidos.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Document = iTextSharp.text.Document;

namespace pedidos.Resources
{
    internal class Imprimir
    {
        // Imprime un pedido
        public static void imprimirPedido(Pedido pedido)
        {
            // Se gestiona el guardado del archivo
            SaveFileDialog guardar = new SaveFileDialog();
            guardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmm");
            guardar.DefaultExt = "pdf";
            guardar.Filter = "Archivos PDF (*.pdf)|*.pdf";

            if (guardar.ShowDialog() == DialogResult.OK)
            {
                // Se instancian los objetos para la creación del PDF
                FileStream stream = new FileStream(guardar.FileName, FileMode.Create);
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);
                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                // Se definen las fuentes
                iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                iTextSharp.text.Font fuente2 = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                
                // Se agrega el encabezado del documento
                pdfDoc.Add(new Paragraph("Detalle Pedido N°: " + pedido.getNumPedido(), fuente));
                pdfDoc.Add(new Paragraph("Fecha y Hora: " + pedido.getFecha(), fuente2));
                pdfDoc.Add(new Paragraph("Empleado: " + pedido.getEmpleado().getNombre() + " " + pedido.getEmpleado().getApellido(), fuente2));
                pdfDoc.Add(iTextSharp.text.Chunk.NEWLINE);
                
                // Se crea una tabla donde irán los datos
                PdfPTable tabla = new PdfPTable(4);
                tabla.WidthPercentage = 100;

                PdfPCell item = new PdfPCell(new Phrase("Item", fuente));
                item.BorderWidth = 0;
                item.BorderWidthBottom = 0.75f;
                item.HorizontalAlignment = Element.ALIGN_CENTER;
                item.VerticalAlignment = Element.ALIGN_TOP;

                PdfPCell cantidad = new PdfPCell(new Phrase("Cantidad", fuente));
                cantidad.BorderWidth = 0;
                cantidad.BorderWidthBottom = 0.75f;
                cantidad.HorizontalAlignment = Element.ALIGN_CENTER;
                cantidad.VerticalAlignment = Element.ALIGN_TOP;

                PdfPCell precioUnitario = new PdfPCell(new Phrase("Precio Unitario", fuente));
                precioUnitario.BorderWidth = 0;
                precioUnitario.BorderWidthBottom = 0.75f;
                precioUnitario.HorizontalAlignment = Element.ALIGN_CENTER;
                precioUnitario.VerticalAlignment = Element.ALIGN_TOP;

                PdfPCell total = new PdfPCell(new Phrase("Total", fuente));
                total.BorderWidth = 0;
                total.BorderWidthBottom = 0.75f;
                total.HorizontalAlignment = Element.ALIGN_CENTER;
                total.VerticalAlignment = Element.ALIGN_TOP;

                // Se agregan las columnas creadas a la tabla                
                tabla.AddCell(item);
                tabla.AddCell(cantidad);
                tabla.AddCell(precioUnitario);
                tabla.AddCell(total);


                // Se recorre la lista del detalle del pedido para ir agregando sus datos a la tabla
                var detallePedido = pedido.getDetalle().getDetallePedido();

                foreach (var det in detallePedido)
                {
                    item = new PdfPCell(new Phrase(det.getNombre(), fuente2));
                    item.BorderWidth = 0;
                   
                    cantidad = new PdfPCell(new Phrase(det.getCantidad().ToString(), fuente2));
                    cantidad.BorderWidth = 0;
                    cantidad.HorizontalAlignment = Element.ALIGN_CENTER;

                    precioUnitario = new PdfPCell(new Phrase("$ " + det.getPrecio().ToString(), fuente2));
                    precioUnitario.BorderWidth = 0;
                    precioUnitario.HorizontalAlignment = Element.ALIGN_CENTER;

                    total = new PdfPCell(new Phrase(det.calcularPrecioTotal().ToString(), fuente2));
                    total.BorderWidth = 0;
                    total.HorizontalAlignment = Element.ALIGN_CENTER;

                    tabla.AddCell(item);
                    tabla.AddCell(cantidad);
                    tabla.AddCell(precioUnitario);
                    tabla.AddCell(total);
                }

                // Se agrega la fila final de la tabla, que contiene el Total
                PdfPCell filaTotal = new PdfPCell(new Phrase("TOTAL", fuente));
                filaTotal.Colspan = 3;
                filaTotal.BorderWidth = 0;
                filaTotal.BorderWidthTop = 0.75f;
                filaTotal.VerticalAlignment = Element.ALIGN_BOTTOM;

                PdfPCell montoTotal = new PdfPCell(new Phrase("$ " + pedido.obtenerPagoTotal().ToString(), fuente));
                montoTotal.BorderWidth = 0;
                montoTotal.BorderWidthTop = 0.75f;
                montoTotal.HorizontalAlignment = Element.ALIGN_CENTER;
                montoTotal.VerticalAlignment = Element.ALIGN_BOTTOM;

                tabla.AddCell(filaTotal);         
                tabla.AddCell(montoTotal);

                pdfDoc.Add(tabla);

                //Se cierran los objetos utilizados para la creación del PDF
                pdfDoc.Close();
                writer.Close();
                stream.Close();
            }

            MessageBox.Show("Documento generado exitosamente", "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
