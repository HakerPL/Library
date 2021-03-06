﻿using System.Collections.Generic;
using System.Linq;
using MySQL.Entities;

namespace Library.Services
{
    public enum FiltrReaderMethod
    {
        NAME,
        SURNAME
    }
    public class FiltrReaders
    {
        public static List<Reader> Filtr(List<Reader> sourceList, FiltrReaderMethod filtrMethod, string filtr)
        {
            List<Reader> list = new List<Reader>();

            switch (filtrMethod)
            {
                case FiltrReaderMethod.NAME:
                    list = sourceList.Where(r => r.Name.Contains(filtr)).ToList();
                    break;

                case FiltrReaderMethod.SURNAME:
                    list = sourceList.Where(r => r.Surname.Contains(filtr)).ToList();
                    break;
            }

            return list;
        }
    }
}
