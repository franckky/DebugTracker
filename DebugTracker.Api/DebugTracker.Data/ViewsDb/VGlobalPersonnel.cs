using System;
using System.Collections.Generic;
using System.Text;

namespace DebugTracker.Data.ViewsDb
{
    public class VGlobalPersonnel
    {
        public int PERSO_num { get; set; }
        public string PERSO_patronyme { get; set; }
        public string PERSO_prenom { get; set; }
        public string PERSO_fullName { get; set; }
        public string PERSO_email { get; set; }
        public string PERSO_loginNT { get; set; }
        public string NomP { get; set; }
        public int PERSO_Responsable_Services { get; set; }
        public int PERSO_ensemble { get; set; }
        public string Ensemble_lib { get; set; }
    }
}
