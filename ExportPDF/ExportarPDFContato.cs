using eAgenda.Dominio.ContatoModule;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using eAgenda.Controladores.ContatoModule;

namespace eAgenda.ExportPDF
{
    /// <summary>
    /// Classe responsável pela criação do PDF do contato
    /// </summary>
    public class ExportarPDFContato
    {

        /// <summary>
        /// Cria um PDF com todos os contatos
        /// </summary>
        public static void ExportarContatosEmPDF()
        {
            ControladorContato controlador = new ControladorContato();
            List<Contato> todosContatos = controlador.SelecionarTodos();

            using (PdfWriter wPdf = new PdfWriter($@"..\..\..\Relatorios\relatorioContatos.pdf", new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);

                Document document = new Document(pdfDocument, PageSize.A4);
                document.Add(new Paragraph("Relatório Contatos").SetTextAlignment(TextAlignment.CENTER).SetBold().SetFontSize(20));

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
            document.Add(new Paragraph("\n\n"));
            document.Add(new Paragraph("Nome do Contato: " + contato.Nome.ToString()));
            document.Add(new Paragraph("Telefone: " + contato.Telefone.ToString()));
            document.Add(new Paragraph("Empresa: " + contato.Empresa.ToString()));
            document.Add(new Paragraph("Email: " + contato.Email.ToString()));
            document.Add(new Paragraph("Cargo: " + contato.Cargo.ToString()));

        }

    }
}
