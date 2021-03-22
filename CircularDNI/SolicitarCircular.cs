using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircularDNI
{
    class SolicitarCircular
    {
        string url = "https://formulario-ddjj.argentina.gob.ar/certificado/gba/categoria/8";

        //Configuracion
        //chrome como incongnito
        ChromeOptions options = new ChromeOptions();
        //options.AddArguments("--incognito")
        IWebDriver driver = new ChromeDriver(@"C:\Users\Poxi\Documents\Chromedriver\");

        public void SolicitarIDA()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Blue;

            driver.Url = "https://formulario-ddjj.argentina.gob.ar/certificado/caba/categoria/8";
            driver.Manage().Window.Maximize();
            driver.Navigate();
            Thread.Sleep(3000);

            #region Parte 2. Datos Personales.

            //1. Nombre

            IWebElement nombre = driver.FindElement(By.Id("nombre"));
            nombre.SendKeys("Julian Marcos");

            //2. Apellido

            IWebElement apellido = driver.FindElement(By.Id("apellido"));
            apellido.SendKeys("Lastra");

            //3. DNI
            IWebElement dni = driver.FindElement(By.Id("dni"));
            dni.SendKeys("39430861");

            //4. Confirmar DNI
            IWebElement confirmarDNI = driver.FindElement(By.Id("dni_confirm"));
            confirmarDNI.SendKeys("39430861");

            //5. N* de tramite del DNI
            IWebElement ntramite = driver.FindElement(By.Id("nro_tramite"));
            ntramite.SendKeys("00098828608");

            //6. Confimar N* de tramite DNI
            IWebElement confirmarNtramite = driver.FindElement(By.Id("nro_tramite_confirm"));
            confirmarNtramite.SendKeys("00098828608");

            //7. Genero
            IWebElement genero = driver.FindElement(By.Id("genero"));
            genero.SendKeys("(M) Masculino");

            //8. CUIL
            IWebElement cuil = driver.FindElement(By.Id("cuil"));
            cuil.SendKeys("20394308618");

            #endregion

            #region Parte 3. Datos de Contacto y domicilio personal.

            //1. Codigo de Area (el 0 ya esta contemplado).
            IWebElement codArea = driver.FindElement(By.Id("cel_cod_area"));
            codArea.SendKeys("11");

            //2. Numero de celular/telefono (el 15 ya esta contemplado).
            IWebElement telefono = driver.FindElement(By.Id("cel_numero"));
            telefono.SendKeys("59363830");

            //3. Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("julianlastra.kz@gmail.com");

            //4. Confirmar Email
            IWebElement confirmarEmail = driver.FindElement(By.Id("email_confirm"));
            confirmarEmail.SendKeys("julianlastra.kz@gmail.com");

            //5. Domicilio de residencia (Calle y numero).
            IWebElement domicilio = driver.FindElement(By.Id("domicilio_domicilio"));
            domicilio.SendKeys("Posadas 289");

            //6. Info adicional domicilio (Piso/Dpto)
            IWebElement piso = driver.FindElement(By.Id("domicilio_domicilio_info_adicional"));
            piso.SendKeys("PB");

            //7. Codigo postal
            IWebElement codigoPostal = driver.FindElement(By.Id("domicilio_cod_postal"));
            codigoPostal.SendKeys("1832");

            //8. Provincia
            IWebElement provincia = driver.FindElement(By.Id("domicilio_provincia_iso"));
            provincia.SendKeys("Gran Buenos Aires");

            //9. Localidad
            IWebElement localidad = driver.FindElement(By.Id("domicilio_localidad"));
            localidad.SendKeys("Lomas de Zamora");

            #endregion

            #region Parte 4. Datos del transporte a usar.

            //IWebElement vehiculo = driver.FindElement(By.XPath("input[@value='Vehículo - Moto']"));
            //vehiculo.Click();

            IReadOnlyCollection<IWebElement> datab = driver.FindElements(By.ClassName("custom-control-input"));
            //IWebElement click2 = datab.Where(x => x.Text.Contains("TMS")).First();
            try
            {
                datab.ElementAt(1).Click();
                
            }
            catch (Exception)
            {
                IWebElement element = datab.ElementAt(1);

                Actions actions = new Actions(driver);

                actions.MoveToElement(element).Click().Perform();

                    Console.Write("");

            }

            #endregion

            #region Parte 5. Datos de las personas a asistir o trasladar

            //1. Domicilio 
            IWebElement domicilio2 = driver.FindElement(By.Id("asistido_domicilio_domicilio"));
            domicilio2.SendKeys("Av. José Maria moreno  873");

            //2. Piso/Dpto.
            IWebElement piso2 = driver.FindElement(By.Id("asistido_domicilio_domicilio_info_adicional"));
            piso2.SendKeys("1ero A");

            //3. Codigo postal Asistido
            IWebElement codigoPostal2 = driver.FindElement(By.Id("asistido_domicilio_cod_postal"));
            codigoPostal2.SendKeys("1424");

            //4. Provincia del asistido
            IWebElement provincia2 = driver.FindElement(By.Id("asistido_domicilio_provincia_iso"));
            provincia2.SendKeys(Keys.Down);

            //5. Localidad del asistido
            IWebElement localidad2 = driver.FindElement(By.Id("asistido_domicilio_localidad"));
            localidad2.SendKeys("Caballito");

            //Datos de la persona trasladada

            //A. Nombre completo
            IWebElement personaB = driver.FindElement(By.Id("integrantes[0][nombre_completo]"));
            personaB.SendKeys("Mariel Roberta Esquifino");

            //B. DNI
            IWebElement dni2 = driver.FindElement(By.Id("integrantes[0][dni]"));
            dni2.SendKeys("23093731");

            //C. Sexo 
            IWebElement sexo = driver.FindElement(By.Id("integrantes[0][sexo]"));
            sexo.SendKeys("(F) Femenino");


            #endregion

            #region Romper catcha 



            #endregion

            //id="btn-solicitar-certificado"
            //Click en Solicitar
            IWebElement solicitar = driver.FindElement(By.Id("btn-solicitar-certificado"));
            //solicitar.Click();

            }

        public void SolicitarVUELTA()
        {

            System.Console.ForegroundColor = System.ConsoleColor.Blue;

            driver.Url = url;
            driver.Manage().Window.Maximize();
            driver.Navigate();
            Thread.Sleep(3000);

            #region Parte 2. Datos Personales.

            //1. Nombre

            IWebElement nombre = driver.FindElement(By.Id("nombre"));
            nombre.SendKeys("Julian Marcos");

            //2. Apellido

            IWebElement apellido = driver.FindElement(By.Id("apellido"));
            apellido.SendKeys("Lastra");

            //3. DNI
            IWebElement dni = driver.FindElement(By.Id("dni"));
            dni.SendKeys("39430861");

            //4. Confirmar DNI
            IWebElement confirmarDNI = driver.FindElement(By.Id("dni_confirm"));
            confirmarDNI.SendKeys("39430861");

            //5. N* de tramite del DNI
            IWebElement ntramite = driver.FindElement(By.Id("nro_tramite"));
            ntramite.SendKeys("00098828608");

            //6. Confimar N* de tramite DNI
            IWebElement confirmarNtramite = driver.FindElement(By.Id("nro_tramite_confirm"));
            confirmarNtramite.SendKeys("00098828608");

            //7. Genero
            IWebElement genero = driver.FindElement(By.Id("genero"));
            genero.SendKeys("(M) Masculino");

            //8. CUIL
            IWebElement cuil = driver.FindElement(By.Id("cuil"));
            cuil.SendKeys("20394308618");

            #endregion

            #region Parte 3. Datos de Contacto y domicilio personal.

            //1. Codigo de Area (el 0 ya esta contemplado).
            IWebElement codArea = driver.FindElement(By.Id("cel_cod_area"));
            codArea.SendKeys("11");

            //2. Numero de celular/telefono (el 15 ya esta contemplado).
            IWebElement telefono = driver.FindElement(By.Id("cel_numero"));
            telefono.SendKeys("59363830");

            //3. Email
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("julianlastra.kz@gmail.com");

            //4. Confirmar Email
            IWebElement confirmarEmail = driver.FindElement(By.Id("email_confirm"));
            confirmarEmail.SendKeys("julianlastra.kz@gmail.com");

            //5. Domicilio de residencia (Calle y numero).
            IWebElement domicilio = driver.FindElement(By.Id("domicilio_domicilio"));
            domicilio.SendKeys("Posadas 289");

            //6. Info adicional domicilio (Piso/Dpto)
            IWebElement piso = driver.FindElement(By.Id("domicilio_domicilio_info_adicional"));
            piso.SendKeys("PB");

            //7. Codigo postal
            IWebElement codigoPostal = driver.FindElement(By.Id("domicilio_cod_postal"));
            codigoPostal.SendKeys("1832");

            //8. Provincia
            IWebElement provincia = driver.FindElement(By.Id("domicilio_provincia_iso"));
            provincia.SendKeys("Gran Buenos Aires");

            //9. Localidad
            IWebElement localidad = driver.FindElement(By.Id("domicilio_localidad"));
            localidad.SendKeys("Lomas de Zamora");

            #endregion

            #region Parte 4. Datos del transporte a usar.

            //IWebElement vehiculo = driver.FindElement(By.XPath("input[@value='Vehículo - Moto']"));
            //vehiculo.Click();

            IReadOnlyCollection<IWebElement> datab = driver.FindElements(By.ClassName("custom-control-input"));
            //IWebElement click2 = datab.Where(x => x.Text.Contains("TMS")).First();
            try
            {
                datab.ElementAt(1).Click();

            }
            catch (Exception)
            {
                IWebElement element = datab.ElementAt(1);

                Actions actions = new Actions(driver);

                actions.MoveToElement(element).Click().Perform();

                Console.Write("");

            }

            #endregion

            #region Parte 5. Datos de las personas a asistir o trasladar

            //1. Domicilio 
            IWebElement domicilio2 = driver.FindElement(By.Id("asistido_domicilio_domicilio"));
            domicilio2.SendKeys("Posadas 289");

            //2. Piso/Dpto.
            IWebElement piso2 = driver.FindElement(By.Id("asistido_domicilio_domicilio_info_adicional"));
            piso2.SendKeys("Planta Alta");

            //3. Codigo postal Asistido
            IWebElement codigoPostal2 = driver.FindElement(By.Id("asistido_domicilio_cod_postal"));
            codigoPostal2.SendKeys("1832");

            //4. Provincia del asistido
            IWebElement provincia2 = driver.FindElement(By.Id("asistido_domicilio_provincia_iso"));
            provincia2.SendKeys(Keys.Down);

            //5. Localidad del asistido
            IWebElement localidad2 = driver.FindElement(By.Id("asistido_domicilio_localidad"));
            localidad2.SendKeys("Lomas de Zamora");

            //Datos de la persona trasladada

            //A. Nombre completo
            IWebElement personaB = driver.FindElement(By.Id("integrantes[0][nombre_completo]"));
            personaB.SendKeys("Stella Maris Banchio");

            //B. DNI
            IWebElement dni2 = driver.FindElement(By.Id("integrantes[0][dni]"));
            dni2.SendKeys("5909930");

            //C. Sexo 
            IWebElement sexo = driver.FindElement(By.Id("integrantes[0][sexo]"));
            sexo.SendKeys("(F) Femenino");


            #endregion

            #region Romper catcha 



            #endregion

            //id="btn-solicitar-certificado"
            //Click en Solicitar
            IWebElement solicitar = driver.FindElement(By.Id("btn-solicitar-certificado"));
            //solicitar.Click();

        }
    }
}
