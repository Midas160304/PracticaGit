def mostrar_menu():
    print("\n=== MENÚ DE PRODUCTOS ===")
    print("1. Registrar productos")
    print("2. Buscar producto")
    print("3. Modificar producto")
    print("4. Mostrar lista completa")
    print("5. Salir")


def main():
    productos = [""] * 6
    registrado = False

    while True:
        mostrar_menu()
        opcion = input("Elige una opción: ")

        # Aseguramos que el usuario escriba un número válido
        if not opcion.isdigit():
            print("Opción inválida.")
            continue

        opcion = int(opcion)

        if opcion == 1:
            print("\n--- REGISTRAR PRODUCTOS ---")
            for i in range(6):
                productos[i] = input(f"Producto {i + 1}: ")
            registrado = True

        elif opcion == 2:
            if not registrado:
                print("Primero debes registrar los productos.")
                continue

            buscar = input("\nIngresa el nombre a buscar: ")
            encontrado = False

            for i in range(6):
                if productos[i].lower() == buscar.lower():
                    print(f"Producto encontrado: {productos[i]} (posición {i})")
                    encontrado = True
                    break

            if not encontrado:
                print("Producto no encontrado.")

        elif opcion == 3:
            if not registrado:
                print("Primero debes registrar los productos.")
                continue

            indice = input("\nIngresa el número de producto a modificar (1-6): ")

            if not indice.isdigit():
                print("Entrada inválida.")
                continue

            indice = int(indice) - 1

            if indice < 0 or indice >= 6:
                print("Índice fuera de rango.")
                continue

            nuevo = input(f"Nuevo nombre para {productos[indice]}: ")
            productos[indice] = nuevo
            print("Producto modificado correctamente.")

        elif opcion == 4:
            if not registrado:
                print("Primero debes registrar los productos.")
                continue

            print("\n--- LISTA COMPLETA DE PRODUCTOS ---")
            for i in range(6):
                print(f"{i + 1}. {productos[i]}")

        elif opcion == 5:
            print("Saliendo del programa...")
            break

        else:
            print("Opción inválida.")


if __name__ == "__main__":
    main()
