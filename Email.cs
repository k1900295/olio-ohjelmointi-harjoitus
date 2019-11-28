using System;
using System.Net.Mail;


namespace ConsoleApp1
{
    public class Email // Luokka sähköpostin lähettämistä varten asunnon- eli tilinomistajalta pankkiin
    {
        public void Postittaa()    //Metodi tiedoston "tilinomistajat.txt" sähköpostittamiseksi sähköpostin liitteenä  
        {
            try
            {
                MailMessage mail = new MailMessage();
                //Määrittele oheen tarvittava sähköpostipalvelin. Outlookin sähköpostipalvelinta "smtp-mail.outlook.com" on käytetty ohjelman testeissä.
                SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com"); //Sähköpostipalvelin

                //Luotu testailua varten sähköpostitili asunnon.omistaja@outlook.com, 
                //mistä nyt tässä koodissa salasan turvallisuussyistä on poistettu.
                //Määrittele lähettäjän sähkpostiosoite ja sen salasana, jos haluat testata ohjelmaa!
                mail.From = new MailAddress("asunnon.omistaja@outlook.com"); //Lähettävä sähköpostiosoite

                //Luotu testailua varten sähköpostitili business.pankki@outlook.com
                //Määrittele toinen vastaanottajan sähkpostiosoite, jos haluat testata ohjelmaa ja pääset sitten katsomaan saapuneita sähköposteja,
                //jollet tiedä nyt määritellyn sähköpostiosoitteen salasaa!
                mail.To.Add("business.pankki@outlook.com"); //Vastaanottava sähköpostiosoite

                mail.Subject = "Tilinomistajakohtaiset tilitapahtumat";

                mail.Body = "mail with attachment";

                System.Net.Mail.Attachment attachment;

                attachment = new System.Net.Mail.Attachment("tilinomistajat.txt");

                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;

                //Määrittele lähettäjän sähkpostiosoite ja sen salasana, jos haluat testata ohjelmaa!
                SmtpServer.Credentials = new System.Net.NetworkCredential("asunnon.omistaja@outlook.com", "TÄHÄN SALASANA");
               
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                Console.Write("\n\n\t Sähköposti lähetetty kohteeseen!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}

