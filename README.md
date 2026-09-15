# C# - Libro de Calificaciones (Actividades 1, 2 y Lab 3)

Proyecto de consola en C# que muestra la evolución orientada a objetos de una clase `LibroCalificaciones`. El desarrollo abarca desde la instanciación básica y métodos simples hasta el uso de constructores, encapsulamiento con propiedades (`get`/`set`) y validación estricta de entradas por consola.

---

## Estructura del Proyecto

El código está dividido en tres etapas secuenciales de aprendizaje:

### 1. Actividad 1: Declaración de Clase e Instanciación Básica
* **Espacio de nombres:** `LibroCalificaciones_1`
* **Conceptos:** Creación de una clase (`LibroCalificacion`), instanciación con el operador `new` y llamada a métodos sin parámetros (`MostrarMensaje()`).
* **Control de flujo:** Validación del tipo de dato ingresado para la cantidad de materias usando `int.TryParse`.

### 2. Actividad 2: Métodos con Parametrización
* **Espacio de nombres:** `LibroCalificaciones_2`
* **Conceptos:** Pasaje de argumentos a métodos (`MostrarMensaje(string nombreCurso)`).
* **Control de flujo:** Manejo de datos de entrada mediante `string.IsNullOrEmpty` para evitar cadenas vacías.

### 3. Lab 3: Encapsulamiento, Constructores y Propiedades
* **Espacio de nombres:** `LibroCalificacionesModificadores`
* **Conceptos:**
  * Atributos privados (`private string nombreCurso`).
  * Constructor parametrizado para inicialización de objetos.
  * Encapsulamiento con propiedades C# (`get` / `set`).
* **Control de flujo:** Sanitización de entradas con `string.IsNullOrWhiteSpace` y parseo seguro con `int.TryParse`.

