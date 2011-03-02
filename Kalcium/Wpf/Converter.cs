using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Data;
using System.Windows.Markup;

namespace Kalcium.Wpf
{
    public abstract class Converter<TSource> : Converter<TSource, object, object>
    { }

    public abstract class Converter<TSource, TTarget> : Converter<TSource, TTarget, object>
    { }

    public abstract class Converter<TSource, TTarget, TParameter> : MarkupExtension, IValueConverter
    {
        protected abstract object Convert(TSource value);
        protected TParameter Parameter{get; set;}

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Parameter = (TParameter)parameter;
            return Convert((TSource)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Parameter = (TParameter)parameter;
            return ConvertBack((TTarget)value);
        }

        protected virtual TSource ConvertBack(TTarget input)
        {
            throw new NotSupportedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
