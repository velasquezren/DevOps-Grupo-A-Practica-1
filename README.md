# Práctica 1: Pipeline de Integración Continua (.NET) 🚀

Este proyecto forma parte del práctico de implementación de un flujo automatizado de **Integración Continua (CI)** para una aplicación desarrollada en .NET.

## 📌 Objetivo del Práctico
Implementar un pipeline básico que automatice la construcción y validación del software cada vez que se realice un cambio en el código fuente.

## 🛠️ Tecnologías Utilizadas
* **Lenguaje/Framework:** .NET 8.0
* **Control de Versiones:** GitHub
* **Orquestador de CI:** Azure DevOps (Pipelines)
* **Pruebas Unitarias:** xUnit

## ⚙️ Configuración del Pipeline
El archivo de configuración del pipeline realiza las siguientes tareas de forma automática:
1. **Checkout:** Obtiene la última versión del código desde el repositorio.
2. **Setup .NET:** Prepara el entorno con el SDK de .NET 8.0.
3. **Restore:** Descarga todas las dependencias necesarias del proyecto.
4. **Build:** Compila el proyecto en modo Release para verificar que no existan errores sintácticos o de referencia.
5. **Test:** Ejecuta las pruebas unitarias para asegurar la integridad lógica del código.

## 🚀 Cómo ejecutar el proyecto localmente

### Requisitos
* Tener instalado el [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0).

### Pasos
1. Clonar el repositorio:
   ```bash
   git clone [https://github.com/velasquezren/DevOps-Grupo-A.git]
   (https://github.com/velasquezren/DevOps-Grupo-A.git)