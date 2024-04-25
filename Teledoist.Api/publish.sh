#!/bin/bash

# Building image for Boris Teledoister Bot
docker build -t paulbuzakov/boris-teledoister-bot:latest .

# Push image to Docker Hub
docker push paulbuzakov/boris-teledoister-bot:latest
