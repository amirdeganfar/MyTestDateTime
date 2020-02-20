# MyTestDateTime

This is my test project. it has some endpoints for getting parameters and send you a decent output base on the route you are called. 

## Installation

#### Register Microsoft key and feed
Before installing .NET, you'll need to:

 * Register the Microsoft key.
 * Register the product repository.
 * Install required dependencies.

This only needs to be done once per machine.

Open a terminal and run the following command.

```bash
sudo rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
```

#### Install the .NET Core SDK
Update the products available for installation, then install the .NET Core SDK. In your terminal, run the following command.

```bash
sudo yum install dotnet-sdk-3.1
```
### Deployment
Running the .net application in an environment other than windows can be cumbersome. For deploying this application on linux CentOS7 please read this short article from microsoft:

``` bash
https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/linux-apache?view=aspnetcore-3.1
```



## Usage

After running the application use the following URls to recieve the desirable output: 
```.net
/api/datetime/day/2020-02-18/2020-02-25
/api/datetime/day/2020-02-18/2020-02-25/second
/api/datetime/day/2020-02-18/2020-02-25/minute
/api/datetime/day/2020-02-18/2020-02-25/hour
/api/datetime/day/2020-02-18/2020-02-25/year
/api/datetime/weekdays/2020-02-18/2020-02-25
/api/datetime/weeks/2020-02-18/2020-02-25

```