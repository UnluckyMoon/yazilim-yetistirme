
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Tüzel Müşteri
    //Coorporate
    //Miras //İnheritance
    // LegalCustomer:Customer bu kod gerçekmüşteri bir müşteridir demek
    // bunu yapmamızın sebebi CustomerManager classında
    // void Add metodundaki Customera hem tüzel hemde gerçek müşterinin verisini yazabilmek.
    class LegalCustomer :Customer
    {
        
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }

    }
}
