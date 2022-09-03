using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // ne gönderirsem onun kredisini hesaplar  IcrediManager
        public void Application(ICrediManager crediManager)
        {
            //Baivuran bilgilerini değerlendirme
            //

            crediManager.Calculate();


        }
        // birden fazla kredinin hesabını yapmak ıstedıgımızde
        // bir list oluşturuyoruz ki bir sürü krediyi içerisinde barındırsın.
        public void Crediİnformation(List<ICrediManager> crediler)
        {
            foreach (var credi in crediler)
            {
                credi.Calculate();
            }
        
        }
    }
}
