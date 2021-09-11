using eAgenda.Dominio.ContatoModule;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using eAgenda.Controladores.ContatoModule;
using System.Threading;

namespace eAgenda.ExportPDF
{
    /// <summary>
    /// Classe responsável pela criação do PDF do contato
    /// </summary>
    public class ExportarPDFContato
    {
        static bool english = Thread.CurrentThread.CurrentUICulture.ToString() == "en-US";
        /// <summary>
        /// Cria um PDF com todos os contatos
        /// </summary>
        public static void ExportarContatosEmPDF()
        {
            ControladorContato controlador = new ControladorContato();
            List<Contato> todosContatos = controlador.SelecionarTodos();
            string url;
            string strParagraph;
            if (english)
            {
                url = $@"..\..\..\Reports\contactsReport.pdf";
                strParagraph = "Contacts Report";
            }
            else
            {
                url = $@"..\..\..\Relatorios\relatorioContatos.pdf";
                strParagraph = "Relatório Contatos";
            }
            using (PdfWriter wPdf = new PdfWriter(url, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph(strParagraph).SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

                foreach (var contato in todosContatos)
                {
                    AdicionarContatoNoDocumento(document, contato);
                }

                document.Close();

                pdfDocument.Close();
            }

        }

        /// <summary>
        /// Método privado que adiciona o contato ao documento
        /// </summary>
        /// <param name="document">Documento do contato</param>
        /// <param name="contato">Contato a ser adicionado</param>
        private static void AdicionarContatoNoDocumento(Document document, Contato contato)
        {
            if (english) 
            {
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Contact name: " + contato.Nome.ToString()));
                document.Add(new Paragraph("Telephone: " + contato.Telefone.ToString()));
                document.Add(new Paragraph("Company: " + contato.Empresa.ToString()));
                document.Add(new Paragraph("Email: " + contato.Email.ToString()));
                document.Add(new Paragraph("Position: " + contato.Cargo.ToString()));
            }
            else
            {
                document.Add(new Paragraph("\n\n"));
                document.Add(new Paragraph("Nome do Contato: " + contato.Nome.ToString()));
                document.Add(new Paragraph("Telefone: " + contato.Telefone.ToString()));
                document.Add(new Paragraph("Empresa: " + contato.Empresa.ToString()));
                document.Add(new Paragraph("Email: " + contato.Email.ToString()));
                document.Add(new Paragraph("Cargo: " + contato.Cargo.ToString()));
            }
        }

    }
}
