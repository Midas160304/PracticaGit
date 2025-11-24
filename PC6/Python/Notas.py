def main():
    n = int(input("¿Cuántos estudiantes? "))

    notas = []
    suma = 0
    aprobados = 0

    for i in range(n):
        nota = float(input(f"Nota del estudiante {i + 1}: "))
        notas.append(nota)
        suma += nota
        if nota >= 11:
            aprobados += 1

    promedio = suma / n if n > 0 else 0

    print()
    print(f"Promedio de notas: {promedio:.2f}")
    print(f"Aprobados: {aprobados}")
    print(f"Desaprobados: {n - aprobados}")


if __name__ == "__main__":
    main()
