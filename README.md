# CALCULADORA CON DELEGADOS

## Explicación del problema

El problema consiste en desarrollar una calculadora en C# que permita ejecutar operaciones matemáticas básicas como sumar, restar, multiplicar y dividir. La condición especial es que no se deben usar estructuras condicionales como `if` o `switch` para ejecutar las operaciones. En lugar de eso, se deben usar **delegados** para hacer el programa más flexible y escalable.

## Definición de delegados

Un delegado es un tipo de dato en C# que guarda la referencia a un método. Es como un "apuntador" que puede señalar a diferentes métodos siempre que tengan la misma forma (mismos parámetros y mismo tipo de retorno). Los delegados permiten tratar los métodos como si fueran variables, es decir, se pueden pasar como parámetros, guardar en arreglos o asignar dinámicamente.

## ¿Por qué usar delegados en vez de llamar a métodos directamente?

Usar delegados en lugar de llamar a métodos directamente es mejor por varias razones:

Usar delegados en lugar de llamar métodos directamente es mejor porque tiene flexibilidad porque puedo cambiar métodos sin tener que cambiar el código principal. También nos aporta escalabilidad porque si luego quiero agregar más opciones es más fácil porque sólo debo de crear un nuevo método. Y al final me proporciona un código más limpio y de forma ordenada.

## Cómo se implementó en el proyecto (pasos)

### Paso 1: Crear el delegado
Primero definí un delegado llamado OperationMatematica que recibe dos números enteros y retorna un número entero:
```
public delegate int OperationMatematica(int A, int B);
```
### Paso 2: Crear los métodos de operaciones

Luego creé una clase llamada PRESENTE_CLASE con los cuatro métodos estáticos: SUMAR, RESTAR, MULTIPLICAR y DIVIDIR. Cada método recibe dos números y retorna el resultado.

### Paso 3: Crear un arreglo de delegados

Después creé un arreglo llamado Operaciones que guarda los cuatro métodos en orden. La posición 0 guarda SUMAR, la posición 1 guarda RESTAR, y así sucesivamente.

Paso 4: Pedir los datos al usuario

El programa pide al usuario que ingrese dos números y seleccione una opción del 1 al 4.

Paso 5: Ejecutar usando el delegado

Finalmente, uso la opción seleccionada y lo ejecuto:
```
int PRODUCTO = Operaciones[SELECCION - 1](N1, N2);
```
# Ejemplos de uso 

Ejemplo 1: Suma

```
ENTRADA:
Primer número que desea el usuario ingresar.
Segundo número que desea el usuario ingresar.
Selección (suma, resta, multiplicación o división).

SALIDA:
PRODUCTO (resultado de la selección).
```
# EVIDENCIAS (pruebas de ejecución):

<img width="1366" height="768" alt="Screenshot (36)" src="https://github.com/user-attachments/assets/193b3c0b-976f-4721-9bd6-54e8254af520" />

<img width="1366" height="768" alt="Screenshot (43)" src="https://github.com/user-attachments/assets/eb67a092-c13d-403b-8a6e-7e2841c53983" />

<img width="1366" height="768" alt="Screenshot (41)" src="https://github.com/user-attachments/assets/78a90caa-5841-4bb3-8762-750c723f3c52" />

<img width="1366" height="768" alt="Screenshot (42)" src="https://github.com/user-attachments/assets/bce03830-ca53-4c31-8ca2-4ddbd7ea8647" />

