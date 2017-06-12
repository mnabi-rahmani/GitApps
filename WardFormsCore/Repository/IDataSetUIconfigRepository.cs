﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WardFormsCore.Data;

namespace WardFormsCore.Repository
{
    public interface IDataSetUIconfigRepository : IRepository<DataSetUIconfig>
    {
         bool DatasetUIConfigExists(int DatasetSectionElementID);

        void AddorUpdateExisting(string data_row, string data_col, string data_sizex, string data_sizey,
            string name);

        IEnumerable<AllElement> getallelements();


    }
}