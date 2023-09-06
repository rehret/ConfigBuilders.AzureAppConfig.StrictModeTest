# ConfigBuilders.AzureAppConfig.StrictModeTest
Sample project to demonstrate `AzureAppConfigurationBuilder` failing to match keys when operating in "Strict" mode and using a key filter.

## Setup & Execution
1. Provide a valid Azure App Configuration connection string for the `"AzureAppConfig_ConnectionString"` app setting.
2. In the Azure App Config instance referenced by said connection string, add a new setting with the key `TestApp:TestKey:AAC`. The value can be any value, though it will be used in validation later, so it should be recognizable.
3. Add an environment variable which will be visible to the running application with the key `TestApp__TestKey__Env`. By default, `EnvironmentConfigBuilder` replaces colon characters with double underscores, so double underscores are used here. As with the Azure App Configuration value, any recognizable value will work here.
4. Execute the application
5. Expect to see output similar to the following:
```
TestKey (Env): 'Test Value (Env)'
TestKey (AAC): ''
```
6. In the App.config, change the mode of the `"AzureAppConfig"` configuration builder from `"Strict"` to `"Greedy"`.
7. Execute the application again.
8. Expect to see output similar to the following:
```
TestKey (Env): 'Test Value (Env)'
TestKey (AAC): 'Test Value (AAC)'
```