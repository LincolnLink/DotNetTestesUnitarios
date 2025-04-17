# DotNetTestesUnitarios + CQRS + MediatR

 - Você deve deixar as interface publica e as classes de implementação internal.

 - Referencia o projeto no seu projeto de teste, para ele poder saber qual projeto testar.
   
 - Adiciona uma configuração no csproj que faz o projeto de teste reconhecer as classes internal!

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

  - Trait , Uma biblioteca que serve para descrever uma categoria de teste.

  - Stryker, teste de mutação.

  - Um teste não pode depender do outro é unitario.

  - O construtor executa a cada teste.

  - construtor é executado a cada teste.

  - as interface devem ser mokadas para fazer um teste em metodo que depende de interface, não moka implementações.

  - Classes devem depender de interfaces e abstrações, e não de implementações.

  - NSubstitute, pega a interface e moka a implementação.

  - record: nova forma de criar objeto.

  - Teste de integração: api usa um teste em memoria.(pesquisar)