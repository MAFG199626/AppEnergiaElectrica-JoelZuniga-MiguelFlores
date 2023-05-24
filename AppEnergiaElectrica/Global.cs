using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppEnergiaElectrica
{
    class Global
    {
        public static List<Mes> Meses = new List<Mes>()
        {
            new Mes(1,"Enero"),
            new Mes(2,"Febrero"),
            new Mes(3,"Marzo"),
            new Mes(4,"Abril"),
            new Mes(5,"Mayo"),
            new Mes(6,"Junio"),
            new Mes(7,"Julio"),
            new Mes(8,"Agosto"),
            new Mes(9,"Septiembre"),
            new Mes(10,"Octubre"),
            new Mes(11,"Noviembre"),
            new Mes(12,"Diciembre"),

         };
        public static List<Año> Años = new List<Año>()
        {
            new Año(1,"2017"),
            new Año(2,"2018"),
            new Año(3,"2019"),
            new Año(4,"2020"),
            new Año(5,"2021"),
            new Año(6,"2022"),

        };
        public static List<DetalleConsumo> DetallesConsumo = new List<DetalleConsumo>()
        {
            //2017 listo
            new DetalleConsumo(1, 1, 1, 5.4689, 7.3467, 5.6149, 4.6162, 5.1395, 5.8914), 
            new DetalleConsumo(2, 1, 2, 5.3702, 7.444, 5.7489, 4.6052, 5.1735, 5.9424), 
            new DetalleConsumo(3, 1, 3, 5.6805, 7.3991, 5.6225, 4.6553, 5.0936, 6.0138), 
            new DetalleConsumo(4, 1, 4, 5.813, 7.4641, 5.7661, 4.7327, 5.1287, 6.1507), 
            new DetalleConsumo(5, 1, 5, 5.9153, 7.4952, 5.7098, 5.0656, 5.1585, 6.2299), 
            new DetalleConsumo(6, 1, 6, 5.888, 7.5736, 5.7314, 5.0379, 5.3221, 6.2652), 
            new DetalleConsumo(7, 1, 7, 5.936, 7.6062, 5.735, 4.8393, 5.2929, 6.2508), 
            new DetalleConsumo(8, 1, 8, 5.9884, 7.654, 5.741, 4.8762, 5.3017, 6.2901), 
            new DetalleConsumo(9, 1, 9, 5.9871, 7.7084, 5.82, 4.9767, 5.4031, 6.3561), 
            new DetalleConsumo(10, 1, 10, 5.9751, 7.7273, 5.8143, 5.2714, 5.3809, 6.3496), 
            new DetalleConsumo(11, 1, 11, 6.0178, 7.7189, 5.8368, 5.2138, 5.4145, 6.3742), 
            new DetalleConsumo(12, 1, 12, 6.0399, 7.8677, 6.0523, 5.0057, 5.391, 6.4048), 
   
   //2018 listo
            new DetalleConsumo(13, 2, 1, 6.0211, 7.8719, 6.0515, 4.9616, 5.381, 6.3656), 
            new DetalleConsumo(14, 2, 2, 5.8895, 7.9868, 6.1339, 4.9623, 5.4876, 6.3938), 
            new DetalleConsumo(15, 2, 3, 6.0705, 7.9683, 6.0609, 4.9586, 5.4045, 6.4323), 
            new DetalleConsumo(16, 2, 4, 6.1875, 7.9802, 6.1409, 5.049, 5.443, 6.5404), 
            new DetalleConsumo(17, 2, 5, 6.2977, 8.0462, 6.2442, 5.2938, 5.4699, 6.6613), 
            new DetalleConsumo(18, 2, 6, 6.1541, 8.0256, 6.2338, 5.2546, 5.5396, 6.5927), 
            new DetalleConsumo(19, 2, 7, 6.1744, 8.0291, 6.0332, 5.0135, 5.5182, 6.4851), 
            new DetalleConsumo(20, 2, 8, 6.2249, 7.997, 6.0597, 5.0737, 5.5297, 6.5024), 
            new DetalleConsumo(21, 2, 9, 6.1825, 8.166, 6.1405, 5.015, 5.5895, 6.5855), 
            new DetalleConsumo(22, 2, 10, 6.1932, 8.1171, 6.1139, 5.3051, 5.6079, 6.5871), 
            new DetalleConsumo(23, 2, 11, 6.1803, 8.126, 6.1486, 5.0386, 5.6215, 6.5981), 
            new DetalleConsumo(24, 2, 12, 6.2806, 8.1351, 6.3592, 5.0763, 5.6064, 6.6326), 
   
   //2019 listo
            new DetalleConsumo(25, 3, 1, 6.3758, 8.3673, 6.4578, 5.2443, 6.6818, 6.5001), 
            new DetalleConsumo(26, 3, 2, 6.3295, 8.6228, 6.539, 5.2687, 6.7457, 6.5963), 
            new DetalleConsumo(27, 3, 3, 6.6024, 8.5686, 6.4329, 5.3464, 6.7359, 6.7055), 
            new DetalleConsumo(28, 3, 4, 6.6481, 8.8591, 6.6848, 5.5181, 6.8617, 6.8703), 
            new DetalleConsumo(29, 3, 5, 6.9263, 8.8587, 6.596, 5.743, 7.0232, 7.0302), 
            new DetalleConsumo(30, 3, 6, 6.8164, 8.9162, 6.572, 5.6983, 7.1481, 7.0414), 
            new DetalleConsumo(31, 3, 7, 7.0131, 9.0255, 6.65, 5.5646, 7.217, 7.0893), 
            new DetalleConsumo(32, 3, 8, 7.0976, 9.0734, 6.6401, 5.6911, 7.2868, 7.1412), 
            new DetalleConsumo(33, 3, 9, 7.1582, 9.312, 6.8295, 5.7918, 7.3978, 7.2991), 
            new DetalleConsumo(34, 3, 10, 7.2155, 9.3536, 6.8523, 6.1842, 7.4592, 7.3426), 
            new DetalleConsumo(35, 3, 11, 7.2353, 9.4794, 6.9382, 6.0893, 7.5678, 7.337), 
            new DetalleConsumo(36, 3, 12, 7.3931, 9.7275, 7.2773, 6.0396, 7.6627, 7.4626), 
  
  //2020 listo
            new DetalleConsumo(37, 4, 1, 7.4192, 9.7805, 7.232, 6.0492, 7.6889, 7.4391), 
            new DetalleConsumo(38, 4, 2, 7.3076, 9.7839, 7.2695, 6.0672, 7.6865, 7.5626), 
            new DetalleConsumo(39, 4, 3, 7.4813, 9.7744, 7.0102, 6.041, 7.6424, 7.5586), 
            new DetalleConsumo(40, 4, 4, 7.564, 9.836, 7.5069, 6.0752, 7.596, 7.6759), 
            new DetalleConsumo(41, 4, 5, 7.6644, 9.8119, 7.4551, 6.2942, 7.5919, 7.6854), 
            new DetalleConsumo(42, 4, 6, 7.519, 9.8302, 7.1974, 6.5151, 7.5868, 7.6307), 
            new DetalleConsumo(43, 4, 7, 7.0131, 9.0255, 6.65, 5.5646, 7.217, 7.0893), 
            new DetalleConsumo(44, 4, 8, 7.3384, 9.4529, 6.8478, 5.9115, 7.6136, 7.4275), 
            new DetalleConsumo(45, 4, 9, 7.2743, 9.5122, 6.8756, 6.0603, 7.644, 7.488), 
            new DetalleConsumo(46, 4, 10, 7.276, 9.4439, 6.6954, 6.2225, 7.7, 7.3847), 
            new DetalleConsumo(47, 4, 11, 7.18, 9.478, 6.7685, 6.4921, 7.6404, 7.3823), 
            new DetalleConsumo(48, 4, 12, 7.2126, 9.6124, 7.0852, 6.0313, 7.6441, 7.3866), 
  
  //2021
            new DetalleConsumo(49, 5, 1, 6.5778, 8.7787, 6.4083, 5.2986, 6.9338, 6.7237), 
            new DetalleConsumo(50, 5, 2, 5.9834, 8.6689, 6.4673, 5.258, 6.8998, 6.7538), 
            new DetalleConsumo(51, 5, 5, 6.1222, 8.5638, 6.2095, 5.2553, 6.8459, 6.7315), 
            new DetalleConsumo(52, 5, 4, 6.23, 8.6523, 6.3913, 5.3598, 6.8984, 6.9029), 
            new DetalleConsumo(53, 5, 5, 6.292, 8.6065, 6.2945, 5.3427, 6.917, 6.919), 
            new DetalleConsumo(54, 5, 6, 6.3176, 8.565, 6.1791, 5.2972, 6.9168, 6.9116), 
            new DetalleConsumo(55, 5, 7, 6.3285, 8.5438, 6.1621, 5.4009, 6.9581, 6.8838), 
            new DetalleConsumo(56, 5, 8, 6.3307, 8.576, 6.1641, 5.3321, 6.915, 6.905), 
            new DetalleConsumo(57, 5, 9, 6.2625, 8.5986, 6.2437, 5.6089, 7.0074, 6.9259), 
            new DetalleConsumo(58, 5, 10, 6.3641, 8.5837, 6.1456, 5.4992, 7.0198, 6.9449), 
            new DetalleConsumo(59, 5, 11, 6.2835, 8.7045, 6.2614, 5.4468, 7.0384, 6.9437), 
            new DetalleConsumo(60, 5, 12, 6.3105, 8.672, 6.4753, 5.3478, 6.8697, 6.9564), 
  
  //2022
            new DetalleConsumo(61, 6, 1, 6.2665, 8.7161, 6.4754, 5.359, 6.8723, 6.9107),
      };
        public class Año
        {
            int id;
            string anio;

            public Año(int id, string anio)
            {
                this.Id = id;
                this.Anio = anio;
            }

            public int Id { get => id; set => id = value; }
            public string Anio { get => anio; set => anio = value; }
        }
            public class Mes
        {
            int id;
            string ms;

            public Mes(int id, string ms)
            {
                this.Id = id;
                this.Ms = ms;
            }

            public int Id { get => id; set => id = value; }
            public string Ms { get => ms; set => ms = value; }
        }
        public class DetalleConsumo
        {
            int id;
            int añoId;
            int mesId;
            double residencia;
            double comercial;
            double industrial;
            double irrigacion;
            double bombeo;
            double promedioNacional;

            public DetalleConsumo(int id, int añoId, int mesId, double residencia, double comercial, double industrial, double irrigacion, double bombeo, double promedioNacional)
            {
                this.Id = id;
                this.AñoId = añoId;
                this.MesId = mesId;
                this.Residencia = residencia;
                this.Comercial = comercial;
                this.Industrial = industrial;
                this.Irrigacion = irrigacion;
                this.Bombeo = bombeo;
                this.PromedioNacional = promedioNacional;
            }

            public int Id { get => id; set => id = value; }
            public int AñoId { get => añoId; set => añoId = value; }
            public int MesId { get => mesId; set => mesId = value; }
            public double Residencia { get => residencia; set => residencia = value; }
            public double Comercial { get => comercial; set => comercial = value; }
            public double Industrial { get => industrial; set => industrial = value; }
            public double Irrigacion { get => irrigacion; set => irrigacion = value; }
            public double Bombeo { get => bombeo; set => bombeo = value; }
            public double PromedioNacional { get => promedioNacional; set => promedioNacional = value; }
        }
    }
}