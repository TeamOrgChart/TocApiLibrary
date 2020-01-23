iwr https://localhost:44320/swagger/docs/v1 -o toc.yaml
autorest --input-file=toc.yaml --csharp --output-folder=tocapilib --namespace=Teamorgchart