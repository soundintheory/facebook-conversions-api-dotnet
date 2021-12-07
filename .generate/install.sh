#!/bin/bash
BASEDIR=$(dirname "$(dirname "$BASH_SOURCE")")
curl https://repo1.maven.org/maven2/org/openapitools/openapi-generator-cli/5.3.0/openapi-generator-cli-5.3.0.jar > "$BASEDIR/.generate/openapi-generator-cli.jar"
chmod u+x "$BASEDIR/.generate/openapi-generator-cli"