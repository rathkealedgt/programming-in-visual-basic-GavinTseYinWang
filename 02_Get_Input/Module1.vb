Module Module1
    ''' <summary>
    '''     This program will show you how to get input from the user.
    ''' </summary>
    ''' <author> Mr Macri </author>
    ''' <date> 10Jun19 </date>
    ''' 
    Sub Main()
        ' Housekeeping
        Dim UserName, OutputMessage As String
        Dim FirstNumber, SecondNumber, Sum, Product As Integer

        ' Ask for user name
        Console.WriteLine("Please enter your name.")
        UserName = Console.ReadLine()

        ' Ask user for two numbers
        Console.WriteLine("Please enter your favorite number")
        FirstNumber = Console.ReadLine()

        Console.WriteLine("Please eneter your second favorite number")
        SecondNumber = Console.ReadLine()

        ' Add numbers together
        Sum = FirstNumber + SecondNumber

        ' Multiply numbers together
        Product = FirstNumber * SecondNumber

        ' Greet user and display maths
        OutputMessage = String.Format("Hello, {0}. The sum of your numbers equals {1}. The product of your numbers equals {2}.", UserName, Sum, Product)
        Console.WriteLine(OutputMessage)
        Console.ReadLine()

    End Sub

End Module
