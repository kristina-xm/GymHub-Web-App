# GymHub Web App
**Gym Hub** is an ASP.NET Core MVC Web App and represents the final project for SoftUni's C# course sequence.<br>

## Table of Contents
1. [Introduction](#introduction)
2. [Technologies](#technologies)
3. [Main Features](#main-features)
4. [Other features](#other-features)

## Introduction
The application is designed for efficient physical activity management and aims to enhance customer and trainer engagement in gyms. Gym Hub provides two types of accounts - Trainee **or** Trainer. Although there are some shared features, *Trainees* and *Trainers* have distinct needs and utilize different functionalities within the app based on their user type.

## Technologies
The project utilizes the following technologies to achieve its goals:<br>
- ASP.NET Core v6.0
- Entity Framework Core
- MS SQL
- cdnjs Library -> fullCalendar.js v6.1.8
- Bootstrap v5.1.0
- BootsWatch theme
- FakeItEasy v.7.4.0 for controller testing

## Main Features
Trainers:
- Have a dashboard with upcoming individual trainings and related Trainees, count of group activities responsible for and list of upcoming group activities classes
- See their weekly schedule, including both individual training and group activities
- Cancel individual training if needed (which updates their schedules and the Trainee's schedule)
- Can edit their personal account info (incl. First name, Last Name, Phone number and Trainer type-specific info)

Trainees:
- Have a dashboard with their upcoming individual and enrollments for group training
- See the trainer's schedule, including both individual training and group activities
- Select the preferred Trainer for individual training and book a time slot when the Trainer is available (Trainee can look at the Trainer's schedule in the booking process)
- Select group activities based on intensity and physical activity levels
- Can cancel enrollment for group activities or individual training booking from their dashboard
- Can edit their personal account info (incl. First name, Last Name, Phone number and Trainee type-specific info)

## Other Features
- The phone number of Trainers is visible only for logged-in users and Trainees who have booked a time slot for training with the specific trainer
- When a Trainee cancels his/her enrollment for a Group activity class, remaining spots increase
- When a Trainee enrols for a Group activity class, remaining spots decrease
- When an Individual training is cancelled (either by Trainer or Trainee), it is removed from the Trainer's calendar schedule


