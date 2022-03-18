using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MobAvaliacao.Controll
{
    public class CREFValidationBehavior : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.TextChanged += OnTextChanged;

            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.TextChanged -= OnTextChanged;

            base.OnAttachedTo(bindable);
        }

        void OnTextChanged(object sender, TextChangedEventArgs args)
        {
            var entry = (Entry)sender;

            entry.Text = FormatarCref(entry.Text);
        }

        private string FormatarCref(string entrada)
        {
            string digits = "";

            for (int i = 0; i < entrada.Length; i++)
            {
                if (i <= 5)
                    digits += entrada.Substring(i, 1);
                else
                    if (i == 6 && !entrada.Substring(i, 1).Contains("-"))
                    digits += "-" + entrada.Substring(i, 1);
                else
                        if (i == 6 && entrada.Substring(i, 1).Contains("-"))
                    digits += entrada.Substring(i, 1);
                else
                            if (i > 6 && i < 8)
                    digits += entrada.Substring(i, 1);
                else
                                if (i == 8 && !entrada.Substring(i, 1).Contains("/"))
                    digits += "/" + entrada.Substring(i, 1);
                else
                                    if (i == 8 && entrada.Substring(i, 1).Contains("/"))
                    digits += entrada.Substring(i, 1);
                else
                                        if (i > 8)
                    digits += entrada.Substring(i, 1);
            }

            return digits;
        }
    }
}
