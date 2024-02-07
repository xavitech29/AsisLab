# Configuración de la Aplicación

Este repositorio contiene el código fuente de la aplicación Asis Lab. Antes de ejecutar la aplicación, es importante configurar correctamente el archivo `App.Config` para garantizar el acceso a la base de datos.

## Configuración de la Base de Datos

Los cambios debes hacerlos en las carpetas de **Infraestructura.AccesoDatos** y **UI.Windows**, se utiliza el archivo `App.Config` para especificar el nombre de la base de datos a la que la aplicación se conectará. Sigue estos pasos para configurar correctamente el archivo `App.Config`:

1. Abre el archivo `App.Config` en un editor de texto o en tu entorno de desarrollo.

2. Busca la sección relacionada con la configuración de la conexión a la base de datos. Puede tener un formato similar al siguiente:

   ```xml
   <connectionStrings>
		<add name="LABEntities" connectionString="metadata=res://*/Model_LAB.csdl|res://*/Model_LAB.ssdl|res://*/Model_LAB.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-VJM26SD\SQLEXPRESS;initial catalog=LAB;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />
	</connectionStrings>
3. Dirigete a la sección **Dominion.Modelo** luego a **Entidades** y busca el archivo en este caso es **Model_AsisLAB.tt**, abre ese archivo y dirigete a la siguiente linea que tendra un formato similiar al siguiente:
4. 
5. ```const string inputFile = @"C:\Users\XAVIER29-PC\Desktop\DS1_UISRAEL\Examen_JamilLicuy\AsisLAB\AsisLAB\Infraestructura.AccesoDatos\Model_AsisLAB.edmx";
