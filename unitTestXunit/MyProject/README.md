# Unit Test (cloud-platform)
## Options
* Xunit **(Selected)**
* Nunit
* MSTest
## Description
These Unit testing framework are all built into C#. Nunit has been around since 2006, and since then it has probably been the testing framework of choice for most teams. Like most things, It is also installed via the NuGet package. xUnit is built based on the experience of NUnit. Compared with Nunit opponents, it will definitely optimize some Nunit things. XUnit also can installed via NuGet. MSTest also appeared after Nunit. It supports 'Assert Inconclusive' which is really helpful for integration tests and they support data-driven tests that are comparable to XUnit.

### Xunit Feature
* Xunit is pretty lean compared to NUnit and MsTest and has been written more recently. Although the .NET framework has evolved since NUnit was first created. XUnit leverage some of the new features to help developers write cleaner test.
* Xunit is aimed at improving test isolation and trying to codify a set of rules to establish a testing standard.
* The property of [Fact] and [Theory] can be extened. Therefore, you can implement your own test function. In addition, Xunit doesn't use test list and '.vsmdi' file to track your testing.
* Microsoft is using xUnit internally, one of its creators is from Microsoft. Xunit was also created by one of the original authors of NUnit.
* Xunit allows us to write less code since its flexibility allows things like subspec which allow you to write only what you need to do.
* Xunit is easier to read and uses intuitive terminology.
## Usage Steps ( Xunit )
```IDE: VSCODE ```
### Step 1: Create testing framework
        dotnet new xunit
### Step 2: Write test Program
        · Add '.csproj' file of program under test to the testing program '.csproj'. For example:
          <ItemGroup>
            <ProjectReference Include="..\xxxx\xxxx.csproj" />
          </ItemGroup>

        · Add feature'[Fact]' to test method

### Steo 3: Execute
        dotnet test
### Others
* Generate Code Coverage Report (.xml)  
```dotnet test --collect:"XPlat Code Coverage"```
* Generate LCOV (.info)  
``` dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=./lcov.info ```


## Reference Links
* https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test
* https://www.tuicool.com/articles/F3eEn2j
* https://www.jondjones.com/architecture/unit-testing/nunit/ms-test-vs-nunit-vs-xunit-which-ones-the-best-you-decide/
* https://www.reddit.com/r/csharp/comments/eg3aui/mstest_nunit_or_xunit/