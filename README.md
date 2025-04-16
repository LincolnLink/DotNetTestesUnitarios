# DotNetTestesUnitarios

 - Voc� deve deixar as interface publica e as classes de implementa��o internal.

 - Referencia o projeto no seu projeto de teste, para ele poder saber qual projeto testar.
   
 - Adiciona uma configura��o no csproj que faz o projeto de teste reconhecer as classes internal!

 ```csharp

    <ItemGroup>
        <AssemblyAttribute Include="System.Runtime.CompilerServices.InternalsVisibleTo">
            <_Parameter1>$(AssemblyName).Tests</_Parameter1>
        </AssemblyAttribute>
    </ItemGroup>

 ```

 - Bogus, biblioteca que gera valores automatico para ser testado.

 - FluentAssertions, uma outra biblioteca para deixar a leitura mais bonita e tem varios metodos que ajuda atestar.

 ```csharp

            // Assert.Equal(expectedId, carro.Id);
            // Assert.Equal(expectedCarName, carro.Name);
            carro.Id.Should().Be(expectedId, "Should be equal");
            carro.Name.Should().Be(expectedCarName);

 ```

  - Trait , Uma biblioteca que serve para descrever uma categoria de teste