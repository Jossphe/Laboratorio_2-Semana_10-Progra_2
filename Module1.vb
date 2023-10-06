Module Module1

    Sub Main()
        Console.WriteLine("UNIVERSIDAD DOCTOR ANDRRES BELLO, REGIONAL SOSNSONATE")
        Console.WriteLine("LABORATORIO 2, PROGRAMACION 2.")
        Console.WriteLine("SEMANA 10.")
        Console.WriteLine()
        Console.WriteLine("DESARROLLADORES: ")
        Console.WriteLine("DAMARYS ELENA OSORIO GUTIERREZ.")
        Console.WriteLine("JOSE RIGOBERTO MENDOZA RIVAS.")


        'ejercicio1()
        ejercicio2()

        Console.Read()

    End Sub

    Sub ejercicio1()

        Console.WriteLine()
        Console.WriteLine("EJERCICIO 1")

        Dim CostoProducto As Single
        Dim DineroEntregado As Single

        Console.WriteLine("Ingrese el costo del artículo a adquirir: $00.00")
        CostoProducto = Convert.ToSingle(Console.ReadLine())

        Console.WriteLine("Ingrese la cantidad de dinero entregada por el cliente: $00.00")
        DineroEntregado = Convert.ToSingle(Console.ReadLine())

        If DineroEntregado > CostoProducto Then
            Dim cambio As Single = DineroEntregado - CostoProducto
            Console.WriteLine("Cambio a entregar: $" & cambio.ToString("00.00"))
            Console.WriteLine("¡GRACIAS POR SU COMPRA!.")
        ElseIf DineroEntregado = CostoProducto Then
            Console.WriteLine("¡GRACIAS POR SU COMPRA!.")
        Else
            Dim falta_pagar As Single = CostoProducto - DineroEntregado
            Console.WriteLine("Falta pagar: $" & falta_pagar.ToString("00.00"))
            If falta_pagar > 0 Then
                Console.WriteLine("Lo sentimos su transaccion no fue realizada, por favor intente nuevamente o Vuelva pronto por el producto deseado.")
            Else
                Console.WriteLine("¡GRACIAS POR SU COMPRA!.")
            End If
        End If

    End Sub

    Sub ejercicio2()

        Console.WriteLine()
        Console.WriteLine("EJERCICIO 2")

        Dim monto As Double
        Dim descuento As Double
        Dim montoFinal As Double

        Console.Write("Ingrese el monto de la compra: ")
        Console.WriteLine()
        monto = Console.ReadLine()

        While monto <> 0
            If monto < 0 Then
                Console.WriteLine("El monto no puede ser negativo.")
            ElseIf monto > 1000 Then
                descuento = monto * 0.1
                montoFinal = monto - descuento
                Console.WriteLine("El monto final con descuento del 10% es: " & montoFinal)
            ElseIf monto > 500 Then
                descuento = monto * 0.05
                montoFinal = monto - descuento
                Console.WriteLine("El monto final con descuento del 5% es: " & montoFinal)
            Else
                Console.WriteLine("El monto final sin descuento es: " & monto)
            End If

            monto = Console.ReadLine()
        End While
    End Sub

End Module

