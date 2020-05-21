using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarieModele;

namespace NivelAccesDate
{
    public interface IStocareData
    {
        void AddMasina(Masina s);
        void Stergere();
        List<Masina> GetMasini();
        Masina GetMasina(string numeVanzator, string tip);
        bool UpdateMasina(Masina s);
        Masina GetMasinaByIndex(int index);

    }
}
