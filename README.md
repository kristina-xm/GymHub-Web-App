# GymHub Web App
**Gym Hub** is an ASP.NET Core MVC Web App and represents the final project for SoftUni's C# course sequence.<br>

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies](#technologies)
3. [Main Features](#main-features)
4. [Application flow](#application-flow)

## Introduction
The application is designed for efficient physical activity management and aims to enhance customer and trainer engagement in gyms. Gym Hub provides two types of accounts - Trainee **or** Trainer. Although there are some shared features, *Trainees* and *Trainers* have distinct needs and utilize different functionalities within the app based on their user type.

## Technologies
The project utilizes the following technologies to achieve its goals:<br>
- ASP.NET Core v6.0
- Entity Framework Core
- MS SQL
- cdnjs Library - fullCalendar v6.1.8
- Bootstrap v5.1.0

## Main Features
Trainers:
- See their weekly schedule, including both individual trainings and/or group activities
- Edit group activities, which are held by them
- Cancel individual training if needed

Trainees:
- See their weekly schedule and the trainer's one, including both individual training and/or group activities
- Select the preferred Trainer for individual training and book a time slot when the Trainer is available
- Select group activities based on their intensity and physical activity levels

## Application flow
![image](https://github.com/kristina-xm/GymHub-Web-App/assets/98902802/49773237-9bdf-45f4-9742-6bf7c2f73584)
