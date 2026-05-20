#  Aventura Espacial

---

# Integrantes

- Fernanda Mizel Hernandez Cruz        Carnet: HC260172
- Adriana Liseyda Cortez de la Cruz    Carnet: CD260338
- Eduardo Alejandro Alvarenga Amaya    Carnet: AA260339

---


##  Descripción del Proyecto

Aventura Espacial es una aplicación desarrollada en C# utilizando Windows Forms y .NET Framework. El sistema simula la exploración de planetas mediante una nave espacial, permitiendo calcular daño térmico, visualizar información de los planetas y controlar el estado de la nave.

El proyecto fue desarrollado como práctica de los temas:
- Estructuras (`struct`)
- Arreglos
- Punteros (`unsafe`)
- Archivos
- Interfaz gráfica (Windows Forms)

---

# Objetivo del Sistema

Simular una misión espacial donde el usuario puede:
- Explorar distintos planetas.
- Visualizar temperatura y oxígeno.
- Calcular daño térmico de la nave.
- Controlar el daño acumulado.
- Detectar cuándo la nave explota por exceso de daño.

---

# Funcionalidades Implementadas

- Exploración aleatoria de planetas.  
- Uso de estructuras para almacenar información.  
- Uso de arreglos de planetas.  
- Cálculo de daño térmico utilizando `unsafe` y punteros.  
- Visualización de información en Labels.  
- Validación de explosión de la nave cuando el daño supera 500.  
- Bloqueo de exploración después de la explosión.  
- Interfaz gráfica sencilla y funcional.

---

# Tecnologías Utilizadas

- Lenguaje: C#
- Framework: .NET Framework
- IDE: Visual Studio
- Interfaz: Windows Forms

---

#  Información Importante

## Uso de Código Unsafe

El proyecto utiliza punteros mediante bloques `unsafe`, por lo tanto es necesario habilitar:

```txt
Permitir código no seguro
```

## Pasos para habilitarlo

1. Click derecho sobre el proyecto.
2. Propiedades.
3. Compilar / Build.
4. Activar:

```txt
Permitir código no seguro
```

---

#  Estructura del Proyecto

```txt
AventuraEspacial/
│
├── AventuraEspacial.cs
├── AventuraEspacial.Designer.cs
├── Program.cs
│
├── PlanetaSistema.cs
│
├── Properties/
│
├── bin/
│
└── obj/
```

---

# Struct Planeta

La estructura `Planeta` almacena:
- Nombre
- Temperatura
- Disponibilidad de oxígeno

---

# Lógica del Sistema

## Exploración

Cada vez que el usuario explora:
- Se selecciona un planeta aleatorio.
- Se calcula daño térmico.
- Se actualiza el daño acumulado.

## Explosión de la Nave

Si el daño acumulado supera 500:
- La nave explota.
- Se muestra una alerta crítica.
- Se bloquean futuras exploraciones.


# Estado del Proyecto

- Proyecto funcional  
- Interfaz gráfica implementada  
- Uso de estructuras y punteros completado  
- Validaciones implementadas 
