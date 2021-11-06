TUTORIAL INICIAL asp.net core 5.0

    dotnet start: Ejecutar el programa
    dotnet build: Para compilar y revisar errores
    dotnet --version: para revisar la version del sdk de .net

    1)  Descargar e instalar .net core 5.0 https://dotnet.microsoft.com/download

    2)  Instalar Visual Studio Code
           2.1) Instalar extensiones:
                    a) C# For Microsft
                    b) C# Extensions jchannon
                    c) C# Extension JosKreativ

    3) Se debe instalar el Framework Entity de forma global.
           a) dotnet tool install --global dotnet-ef (instalacion del entity Framework)
           b) dotnet tool update --global dotnet-ef (actualizacion del entity Framework)

    4) Instalar la solucion de Entity Framework (el programa que se va a construir)
            (MiprimeraApp es el nombre del programa a   construir)
            dotnet new sln -o MiprimeraApp

    5) Instalar las librerias para generar la conexion con la base de datos e implementar las entidades del programa.
        a) dotnet new classlib -o MipriemraApp.Persistencia
        b) dotnet new classlib -o MipriemraApp.Dominio

    6) Instalar la aplicacion web para crear el frontend del programa
        a) dotnet new webapp -o MiprimeraApp.frontend

    7) Instalar la libreria de consola para realizar pruebas del programa.
        a) dotnet new console -o MiprimeraApp.Consola

    8) Instalacion de paquetes:
                --version 5.0.9 (opciona para instalar una version especifica)
        dotnet add package Microsoft.EntityFrameworkCore 
        dotnet add package Microsoft.EntityFrameworkCore.Tools
        dotnet add package Microsoft.EntityFrameworkCore.Design
        dotnet add package Microsoft.EntityFrameworkCore.SqlServer
    
        a) Carpeta Consola
            dotnet add package Microsoft.EntityFrameworkCore.Design

        b) Carpeta Frontend
        
        c) Carpeta Persistencia
            dotnet add package Microsoft.EntityFrameworkCore 
            dotnet add package Microsoft.EntityFrameworkCore.Tools
            dotnet add package Microsoft.EntityFrameworkCore.Design
            dotnet add package Microsoft.EntityFrameworkCore.SqlServer
