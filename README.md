# PermisosUsuarios

# Levantar aplicacion de escritorio en ambiente de desarrollo

## Requisitos previos
1. Clonar el proyecto: Asegúrate de tener los permisos necesarios para clonar el repositorio en tu equipo.
2. Instalar MySQL: Verifica que tienes MySQL instalado y funcionando correctamente en tu sistema.

## Crear la Base de Datos:
3. Crea una base de datos llamada pruebatecnica.
4. Importa el archivo pruebatecnica.sql ubicado en la carpeta source. Este archivo contiene el esquema y datos necesarios.
    Nota: Se han modificado algunas claves en el script para mejorar el funcionamiento de la aplicación.

## Instalar MySQL Connector:
6. Instala mysql-connector-net-9.1.0 para asegurar la compatibilidad entre VB.NET y MySQL.

## Configuración del Proyecto
7. Abrir el Proyecto en Visual Studio:
8. Abre el archivo de solución (.sln) en Visual Studio.

## Configurar la Cadena de Conexión:
9. Ubica el archivo ConexionDB.vb en la solución del proyecto.
10. Actualiza la variable connectionString en el archivo ConexionDB.vb con los parámetros correctos de tu entorno:
    connectionString As String = "Server=localhost;Database=pruebatecnica;User ID=root;Password=;charset=latin1;"
    Cambiar User ID y Password según las credenciales de tu servidor MySQL.

## Ejecución
Ejecutar el Proyecto:
Ejecuta el proyecto desde Visual Studio para confirmar que se conecta correctamente a la base de datos y funciona según lo esperado.




