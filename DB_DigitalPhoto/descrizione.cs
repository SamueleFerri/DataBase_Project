//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB_DigitalPhoto
{
    using System;
    using System.Collections.Generic;
    
    public partial class descrizione
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public descrizione()
        {
            this.fotoes = new HashSet<foto>();
        }
    
        public int idDescrizione { get; set; }
        public string descrizione1 { get; set; }
        public string commento { get; set; }
        public int qualità_foto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<foto> fotoes { get; set; }

        public override string ToString()
        {
            return this.descrizione1 + "\nCommento Fotografo: " + this.commento + "\nQualità foto (da 1 a 5): " + this.qualità_foto;
        }
    }
}
