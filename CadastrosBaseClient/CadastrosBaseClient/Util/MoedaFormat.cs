﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Globalization;

namespace CadastrosBaseClient.Util
{
    [ValueConversion(typeof(double), typeof(string))] 
    public class MoedaFormat:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string resultado = string.Empty;
            if (value != null)
            {
                decimal valor = (decimal)value;
                resultado = valor.ToString("N2", CultureInfo.CreateSpecificCulture("pt-BR")); 
            }
            return resultado;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal resultado = 0;
            if (value != null)
            {
                string valor = value.ToString();
                decimal.TryParse(valor, out resultado);
            }
            return resultado;            
        }
    }
}
