# AsyncDownloaderMethods

This repository contains two simple yet powerful methods to download content asynchronously from a provided URL using C#. 

## Methods:

1. `DownloadStringAsync`: This method downloads the content from a provided URL asynchronously.
2. `DownloadStringWithContinueWith`: This method uses the `ContinueWith` function to download the content, which allows for additional processing after the completion of the initial task. 

## Usage

Replace the URL "https://example.com" in the `Main` method with the URL you want to download the content from. 

Ensure you handle any exceptions that may be thrown if the URL is not reachable, if there's no internet access, or if the content at the URL is not text (e.g., an image or other binary content). 

## Running the Program

Compile and run the program. The console output will show the content of the URL as downloaded by both methods.

Enjoy exploring the world of asynchronous programming in C#!
