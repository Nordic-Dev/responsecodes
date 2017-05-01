# Response Codes

A simple ASP.NET Core app that returns specific response codes when specific endpoints are called. It can come in handy when you need a quick and dirty way to test your application receiving specific responses from an API.

## Setup

> git clone https://github.com/Nordic-Dev/responsecodes.git
> 
> cd responsecodes\responsecodes
> 
> dotnet restore
> 
> dotnet build -c Release

## Running

You can install as an IIS site, or run on the command line using:
> dotnet run

## Usage

The /200 endpoint returns 200
The /201 endpoint returns 201
The /400 endpoint returns 400
The /401 endpoint returns 401
The /500 endpoint returns 500

## Examples
https://codes.nordicdev.io/200
https://codes.nordicdev.io/201
https://codes.nordicdev.io/400
https://codes.nordicdev.io/401
https://codes.nordicdev.io/500




