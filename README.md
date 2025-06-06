# C# Sample Code for the CyberSource SDK

[![Build Status](https://app.travis-ci.com/CyberSource/cybersource-rest-samples-csharp.svg?branch=master)](https://app.travis-ci.com/CyberSource/cybersource-rest-samples-csharp)

This repository contains two applications that demonstrate integration with the CyberSource REST APIs through our SDKs.

## .NET Framework

The application `cybersource-rest-samples-csharp.sln` contains working code samples in a .NET 4.6.1 application which uses the [CyberSource .NET SDK](https://github.com/CyberSource/cybersource-rest-client-dotnet).

For a more detailed explanation of how to use this application, please refer to [README_Net461.md](./README_Net461.md).

## .NET Core

The application `cybersource-rest-samples-netcore.sln` contains working code samples in a .NET Core 3.1 application the [CyberSource .NET Standard SDK](https://github.com/CyberSource/cybersource-rest-client-dotnetstandard).

For a more detailed explanation of how to use this application, please refer to [README_NetCore.md](./README_NetCore.md).

## Run Environments

The run environments that were supported in CyberSource .NET SDK and CyberSource .NET Standard SDK have been deprecated.
Moving forward, the SDKs will only support the direct hostname as the run environment.

For the old run environments previously used, they should be replaced by the following hostnames:

|              Old Run Environment              |               New Hostname Value               |
|-----------------------------------------------|------------------------------------------------|
|`cybersource.environment.sandbox`              |`apitest.cybersource.com`                       |
|`cybersource.environment.production`           |`api.cybersource.com`                           |
|`cybersource.environment.mutualauth.sandbox`   |`api-matest.cybersource.com`                    |
|`cybersource.environment.mutualauth.production`|`api-ma.cybersource.com`                        |
|`cybersource.in.environment.sandbox`           |`apitest.cybersource.com`                       |
|`cybesource.in.environment.production`         |`api.in.cybersource.com`                        |

For example, replace the following code in the Configuration file:

```csharp
// For TESTING use
_configurationDictionary.Add("runEnvironment", "cybersource.environment.sandbox");

// For PRODUCTION use
// _configurationDictionary.Add("runEnvironment", "cybersource.environment.production");
```

with the following code:

```csharp
// For TESTING use
_configurationDictionary.Add("runEnvironment", "apitest.cybersource.com");

// For PRODUCTION use
// _configurationDictionary.Add("runEnvironment", "api.cybersource.com");
```

## Local changes for testing 

1. Set up your Sandbox account in CyberSource and get the following:
- merchantId
- merchantsecretKey
- merchantKeyId

And then for the certificate be sure to note the following:
- certificate filename
- certificate password (this is the password you entered at the time of creation in the CyberSource portal)

2. Modify the code in this repository in the following areas:

- [Source/Configuration.cs](.\Source\Configuration.cs) where it requires the information from step (1)
- [cybersource-rest-samples-netcore.csproxy](.\cybersource-rest-samples-netcore.csproxy) where the code copies the certificate to the output directory, change it to your filename (this step may not be required on Windows. I had to do it on MAC).

```
  <ItemGroup>
    <None Include="Source\Resource\bigwdevsandbox_1747879301.p12">
      <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
    </None>
  </ItemGroup>
```
3. Build the solution - either from the IDE or with these commands
```
dotnet clean cybersource-rest-samples-netcore.csproj
dotnet build cybersource-rest-samples-netcore.csproj
```

4. Run the solution.  At the prompt below type `BasicDMTransaction` to run the Decision Manager 
```
Type a sample name & then press <Return> 
```
Confirm it returns a 201.

5. Go to the CyberSource portal at https://ebctest.cybersource.com/ebc2/ and Navigate to Transactions -> Transaction Management to confirm the creation.

## Disclaimer

Cybersource may allow Customer to access, use, and/or test a Cybersource product or service that may still be in development or has not been market-tested (“Beta Product”) solely for the purpose of evaluating the functionality or marketability of the Beta Product (a “Beta Evaluation”). Notwithstanding any language to the contrary, the following terms shall apply with respect to Customer’s participation in any Beta Evaluation (and the Beta Product(s)) accessed thereunder): The Parties will enter into a separate form agreement detailing the scope of the Beta Evaluation, requirements, pricing, the length of the beta evaluation period (“Beta Product Form”). Beta Products are not, and may not become, Transaction Services and have not yet been publicly released and are offered for the sole purpose of internal testing and non-commercial evaluation. Customer’s use of the Beta Product shall be solely for the purpose of conducting the Beta Evaluation. Customer accepts all risks arising out of the access and use of the Beta Products. Cybersource may, in its sole discretion, at any time, terminate or discontinue the Beta Evaluation. Customer acknowledges and agrees that any Beta Product may still be in development and that Beta Product is provided “AS IS” and may not perform at the level of a commercially available service, may not operate as expected and may be modified prior to release. CYBERSOURCE SHALL NOT BE RESPONSIBLE OR LIABLE UNDER ANY CONTRACT, TORT (INCLUDING NEGLIGENCE), OR OTHERWISE RELATING TO A BETA PRODUCT OR THE BETA EVALUATION (A) FOR LOSS OR INACCURACY OF DATA OR COST OF PROCUREMENT OF SUBSTITUTE GOODS, SERVICES OR TECHNOLOGY, (B) ANY CLAIM, LOSSES, DAMAGES, OR CAUSE OF ACTION ARISING IN CONNECTION WITH THE BETA PRODUCT; OR (C) FOR ANY INDIRECT, INCIDENTAL OR CONSEQUENTIAL DAMAGES INCLUDING, BUT NOT LIMITED TO, LOSS OF REVENUES AND LOSS OF PROFITS.
