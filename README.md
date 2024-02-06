# Configuración de la Aplicación

Este repositorio contiene el código fuente de la aplicación Asis Lab. Antes de ejecutar la aplicación, es importante configurar correctamente el archivo `App.Config` para garantizar el acceso a la base de datos.

## Configuración de la Base de Datos

En la infraestructura de acceso a datos, se utiliza el archivo `App.Config` para especificar el nombre de la base de datos a la que la aplicación se conectará. Sigue estos pasos para configurar correctamente el archivo `App.Config`:

1. Abre el archivo `App.Config` en un editor de texto o en tu entorno de desarrollo.

2. Busca la sección relacionada con la configuración de la conexión a la base de datos. Puede tener un formato similar al siguiente:

   ```xml
   <connectionStrings>
       <add name="NombreConexion" connectionString="Data Source=NombreServidor;Initial Catalog=NombreBaseDatos;User ID=Usuario;Password=Contraseña;" providerName="System.Data.SqlClient" />
   </connectionStrings>
