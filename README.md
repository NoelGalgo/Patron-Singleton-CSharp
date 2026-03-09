# Patrón Singleton en C#

## Alumno
Serna Segura Noel Alberto 

## Numero de control 
22210354

## Materia
Patrones de Diseño

## Descripción
Este repositorio contiene un ejemplo del patrón Singleton en C# aplicado a una central de emergencias 911.

## Contenido del repositorio

- explicación
- Diagrama UML
- Código ejecutable 
- Conclusion

# Identificación y explicación

## 1. Atributo estático de la instancia

El atributo estático es la variable donde se guarda la única instancia de la clase.  
Se declara como **static** para que pertenezca a la clase y no a un objeto.

Su función es verificar si el objeto ya fue creado. Si no existe, se crea; si ya existe, se usa el mismo.

Ejemplo:

```csharp
private static Central_911 instancia;
```


## Conclusión

El patrón Singleton permite que una clase tenga una sola instancia dentro del programa.  
Esto ayuda a evitar que se creen varios objetos innecesarios y permite que todo el sistema utilice la misma instancia.

En este ejercicio se pudo observar que el uso de un atributo estático y un constructor privado controla la creación del objeto.  
De esta forma se asegura que solo exista una instancia y que todas las partes del programa trabajen con ella.
