# Guía de Instalación

## Índice

- [Instalación de SQL Server](#instalación-de-sql-server)
- [Instalación de Visual Studio](#instalación-de-visual-studio)
- [Descarga de Archivos del Proyecto](#descarga-de-archivos-del-proyecto)
  - [Opción 1](#opción-1)
  - [Opción 2](#opción-2)
- [Ejecución del Programa](#ejecución-del-programa)

---

## Instalación de SQL Server

1. Ingresar a la página de [Descargas de SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads).
   
2. Seleccionar "Descargar ahora" debajo de la opción Developer.
   ![1.png](master/Documentacion/imagenes/1.png)

3. Una vez descargado el instalador, ejecutarlo. Se mostrará la siguiente ventana.
   ![2.png](master/Documentacion/imagenes/2.png)

4. Seleccionar "Instalación básica".
   ![3.png](master/Documentacion/imagenes/3.png)

5. Seleccionar "Sí" y luego "Aceptar".
   ![4.png](master/Documentacion/imagenes/4.png)

6. Seleccionar "Instalar".
   ![5.png](master/Documentacion/imagenes/5.png)

7. Una vez instalado, se mostrará la siguiente ventana.
   ![6.png](master/Documentacion/imagenes/6.png)

8. Seleccionar "Instalar SSMS".
   ![7.png](master/Documentacion/imagenes/7.png)

9. Bajar hasta donde dice "Descarga de SSMS" y presionar en "Descargar SQL Server Management Studio (SSMS)".
   ![8.png](master/Documentacion/imagenes/8.png)

10. Una vez descargado el instalador, iniciarlo y se mostrará la siguiente ventana.
    ![9.png](master/Documentacion/imagenes/9.png)

11. Seleccionar "Instalar" y esperar hasta que finalice la instalación.
    ![10.png](master/Documentacion/imagenes/10.png)

12. Una vez finalizado, presionar en "Cerrar" y abrir el programa SQL Server Management Studio.
    ![11.png](master/Documentacion/imagenes/11.png)

13. En la ventana que aparece con la información ya rellenada, presionar en "Connect" para conectarse al servidor de base de datos.

---

## Instalación de Visual Studio

1. Ir al enlace [Descargar Visual Studio](https://visualstudio.microsoft.com/es/downloads/).
   
2. Seleccionar la opción "Descarga gratuita" de la versión Community.
   ![12.png](master/Documentacion/imagenes/12.png)

3. Una vez descargado el instalador, ejecutarlo.
   ![13.png](master/Documentacion/imagenes/13.png)

4. Presionar en "Continuar" y se mostrará la siguiente ventana.
   ![14.png](master/Documentacion/imagenes/14.png)

5. Después de completarse el proceso, se mostrará la siguiente ventana. Seleccionar la opción "Desarrollo de escritorio .NET".
   ![15.png](master/Documentacion/imagenes/15.png)

6. Seleccionar el apartado de "Componentes individuales" y asegurarse de tener marcada la opción ".NET 6.0 Runtime". Luego seleccionar "Instalar".
   ![16.png](master/Documentacion/imagenes/16.png)

7. El proceso de instalación comenzará. Esperar hasta que la instalación termine.
   ![17.png](master/Documentacion/imagenes/17.png)

8. Una vez finalizado el proceso de instalación, se mostrará la siguiente ventana.
   ![18.png](master/Documentacion/imagenes/18.png)

9. Seleccionar "Omitir", iniciar sesión o crear una cuenta para iniciar sesión.
   ![19.png](master/Documentacion/imagenes/19.png)

10. Seleccionar un tema y presionar en "Iniciar Visual Studio".
    ![20.png](master/Documentacion/imagenes/20.png)

11. Se mostrará la ventana de inicio de Visual Studio.
    ![21.png](master/Documentacion/imagenes/21.png)

---

## Descarga de Archivos del Proyecto

### Opción 1

1. Seleccionar la opción "Clonar un repositorio" en la ventana de Visual Studio y pegar el siguiente enlace en "Ubicación del repositorio":
   [https://github.com/jeremyquinde/ProyectoConstruccion.git](https://github.com/jeremyquinde/ProyectoConstruccion.git)
   ![22.png](master/Documentacion/imagenes/22.png)

2. Presionar en "Clonar".
   ![23.png](master/Documentacion/imagenes/23.png)

### Opción 2

1. Ingresar al [GitHub del proyecto](https://github.com/jeremyquinde/ProyectoConstruccion).
   ![24.png](master/Documentacion/imagenes/24.png)

2. En el botón verde que dice "<> Code", presionar y se desplegará el siguiente menú de opciones.
   ![25.png](master/Documentacion/imagenes/25.png)

3. Seleccionar la opción "Download .zip".
   ![26.png](master/Documentacion/imagenes/26.png)

4. Descomprimir la carpeta descargada y se mostrarán las siguientes carpetas. Ingresar en la carpeta "proyecto construcción".
   ![27.png](master/Documentacion/imagenes/27.png)

5. Una vez dentro de la carpeta, ejecutar el archivo "ProyectoFinalCS.sln". Esto abrirá el proyecto directamente en Visual Studio.
   ![28.png](master/Documentacion/imagenes/28.png)

---

## Ejecución del Programa

1. Dentro de la carpeta "proyecto construcción" descargada, ejecutar el archivo "SQLProyectoFinal".
   
2. Se abrirá dentro del programa SQL Server Management Studio. Seleccionar todo con `Ctrl+A` o con el ratón y presionar en el botón "Execute".
   ![25.png](master/Documentacion/imagenes/25.png)

3. Esto iniciará el proceso de creación de tablas y procedimientos almacenados.
   ![26.png](master/Documentacion/imagenes/26.png)

4. Una vez completado el proceso de la base de datos, volver a la ventana de Visual Studio con el proyecto abierto.
   ![27.png](master/Documentacion/imagenes/27.png)

5. Presionar en el botón de "Play" relleno en verde que dice "CapaPresentacion" para iniciar el proyecto en modo debug o el botón de "Play" con bordes en verde para iniciar el proyecto sin modo debug.
   ![28.png](master/Documentacion/imagenes/28.png)

6. Esto iniciará el programa con la ventana de inicio de sesión.
   ![28.png](master/Documentacion/imagenes/28.png)
