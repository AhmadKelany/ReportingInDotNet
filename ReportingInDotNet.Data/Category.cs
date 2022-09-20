using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportingInDotNet.Data;

public enum Category
{
    [Description("دواء")]
    Drug,
    [Description("طعام")]
    Food,
    [Description("شراب")]
    Drink,
    [Description("أداة")]
    Tool,
    [Description("كتاب")]
    Book
}
