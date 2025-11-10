# proyecto-agraria

Sistema de gestión agraria desarrollado en C# con Windows Forms.

## Build Automatizado

Este proyecto incluye un workflow de GitHub Actions que construye automáticamente la aplicación cuando se crea un tag.

### Crear un Release

Para generar una build automática:

```bash
# Crear y subir un tag
git tag v1.0.0
git push origin v1.0.0
```

El workflow:
- Se ejecuta en un contenedor Windows (`windows-latest`)
- Compila el proyecto con .NET 8.0
- Genera los archivos publicados en modo Release
- Guarda los artefactos con el nombre del tag

Los artefactos compilados estarán disponibles en la sección "Actions" del repositorio.