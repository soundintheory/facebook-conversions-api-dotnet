#!/bin/bash
BASEDIR=$(dirname $(dirname "$BASH_SOURCE"))
java -jar "$BASEDIR/.generate/openapi-generator-cli.jar" generate \
   -i https://raw.githubusercontent.com/facebookincubator/Facebook-Server-Side-API-Swagger/main/server-side-api.yaml \
   -g csharp \
   -c "$BASEDIR/.generate/config.json"
   -o "$BASEDIR"