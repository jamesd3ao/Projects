using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Hello
{
    public class App : Application
    {
        public App()
        {
            int fuente = 48;
            // The root page of your application
            //MainPage = new ContentPage
            //{
            //Content = new Label
            //{
            //    Text = "Texto Arriba",
            //    HorizontalOptions=LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //},
            //Device.OnPlatform(iOS: () =>
            //{
            //    Padding = new Thickness(0, 20, 0, 0);
            //});


            //               Content = new Label
            //               {
            //                   //VerticalOptions = LayoutOptions.Center,
            //                   Text =
            //"Mr. Sherlock Holmes, who was usually very late in " +
            //"the mornings, save upon those not infrequent " +
            //"occasions when he was up all night, was seated at " +
            //"the breakfast table. I stood upon the hearth-rug " +
            //"and picked up the stick which our visitor had left " +
            //"behind him the night before. It was a fine, thick " +
            //"piece of wood, bulbous-headed, of the sort which " +
            //"is known as a \u201CPenang lawyer.\u201D Just " +
            //"under the head was a broad silver band, nearly an " +
            //"inch across, \u201CTo James Mortimer, M.R.C.S., " +
            //"from his friends of the C.C.H.,\u201D was engraved " +
            //"upon it, with the date \u201C1884.\u201D It was " +
            //"just such a stick as the old-fashioned family " +
            //"practitioner used to carry\u2014dignified, solid, " +
            //"and reassuring."
            //               },
            //               BackgroundColor = Color.Yellow,
            //               //TextColor = Color.Blue,
            //               Padding = new Thickness(5, Device.OnPlatform(20, 5, 5), 5, 5),

            var scrollview = new ScrollView
            {

                Content = new StackLayout
                {
                    //VerticalOptions = LayoutOptions.Center,
                    Children = {
                    new Label {
                        HorizontalTextAlignment = TextAlignment.Center,
                        Text = "Agenda",
                        BackgroundColor=Color.White,
                        TextColor = Color.Black,
                        FontSize = fuente,
                        FontAttributes= FontAttributes.Bold,

                    },
                    new Label
                    {
                        Text="Nombres",
                        FontSize = fuente,
                    },

                    new Label
                    {
                        Text="Apellidos",
                        FontSize = fuente,
                    },
                    new Label
                    {
                        Text="Dirección",
                        FontSize = fuente,
                    },

                    new Label
                    {
                        Text="Teléfono fijo",
                        FontSize = fuente,
                    },

                    new Label
                    {
                        Text="Celular",
                        FontSize = fuente,
                    },
                    new Label
                    {
                        Text="Correo",
                        FontSize = fuente,
                    },
                    //new Label {
                    //    Text="Otro texto."
                    //},
                    //new Xamarin.Forms.Picker
                    //{
                    //  //Source="c33ch.jpg"  
                    //},
                    //new Xamarin.Forms.Button {
                    //    Text="Presioname"
                    //}
                }
                }
            };
            //};
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
