# MessageBus sample

## Prerequisites

1. Build [Sitecore 9.1.1 Docker images](https://github.com/Sitecore/docker-images):

   ```powershell
   Import-Module ".\modules\SitecoreImageBuilder" -Force

   SitecoreImageBuilder\Invoke-Build -Path ".\images" -InstallSourcePath C:\Sitecore -Registry myregistry -Tags "*9.1.1*" -PushMode "Never"
   ```

## Samples CM/CD

Go to [CM instance](http://localhost:44001/api/ssc/messagebus). 
Notice message like the following in CM logs:

   `2320 11:54:28 INFO  [MessageBusSample]: Message received: 'Hello from Standalone!'`

Go to [CD instance](http://localhost:44002/api/ssc/messagebus). See in CM logs:

`1276 11:54:29 INFO  [MessageBusSample]: Message received: 'Hello from ContentDelivery!'`