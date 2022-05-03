using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class ConvertService
    {
        public enum IntegerType
        {
            Id
        }

        public enum DecimalType
        {
            Value
        }

        public static DataTable ToDataTable<T>(List<T> list)
        {
            var listInteger = Enum.GetValues(typeof(IntegerType)).Cast<IntegerType>().Select(x => x.ToString()).ToList();
            var listDecimal = Enum.GetValues(typeof(DecimalType)).Cast<DecimalType>().Select(x => x.ToString()).ToList();

            var data = new DataTable();

            foreach (var i in typeof(T).GetProperties())
            {
                if (i.Name[0] != '_')
                {
                    if (listInteger.Any(x => x == i.Name))
                    {
                        data.Columns.Add(i.Name, typeof(Int64));
                    }
                    else
                    {
                        if (listDecimal.Any(x => x == i.Name))
                        {
                            data.Columns.Add(i.Name, typeof(decimal));
                        }
                        else
                        {
                            data.Columns.Add(i.Name);
                        }
                    }
                }
            }

            var properties = typeof(T).GetProperties();
            foreach (var item in list)
            {
                var element = new List<object>();
                foreach (var property in properties)
                {
                    if (property.Name[0] != '_')
                    {
                        element.Add(property.GetValue(item));
                    }
                }

                DataRow dataRow = data.NewRow();
                dataRow.ItemArray = element.ToArray();
                data.Rows.Add(dataRow);
            }

            return data;
        }
    }
}
