# Hotel Guide Tutorial

This project consists of two microservices: **Hotel** and **Report**.

RabbitMQ is used for asynchronous communication between the two microservices. The application runs with Docker, and report requests are processed through a message queue before being saved to the database.

## Technologies Used

- C#
- ASP.NET Core Web API
- Microservices Architecture
- RabbitMQ
- Docker
- Database Integration

## Running RabbitMQ with Docker

Run the following command to start a RabbitMQ container with the management interface enabled:

```bash
docker run -d -p 1453:15672 -p 5672:5672 --name rabbitmqcontainer rabbitmq:3-management
```

## Project Workflow

### 1. Docker and RabbitMQ

RabbitMQ runs in a Docker container and provides the message broker infrastructure used by the microservices.

![Docker](https://github.com/user-attachments/assets/a5c67334-2d4b-4551-a7d8-9a5f58fee229)

### 2. Sending a Report Request

A sample report request retrieves hotels located in Istanbul.

![Report Request](https://github.com/user-attachments/assets/961be1d9-9f28-45ae-b4bb-c8923c2e9b61)

### 3. Processing the Request in the Report Controller

When the request reaches the Report Controller, it initiates the report generation workflow.

![Report Controller](https://github.com/user-attachments/assets/51edc569-5fde-4d29-a8d3-e87e2f7d92d9)

### 4. Publishing the Message to RabbitMQ

The report request is published to RabbitMQ, allowing communication between the microservices through a message queue.

![RabbitMQ Queue](https://github.com/user-attachments/assets/564b6976-3aab-4682-968d-960106a0c28e)

### 5. Consuming the Message

A report listener subscribes to the relevant RabbitMQ queue and processes incoming report requests.

![RabbitMQ Subscription](https://github.com/user-attachments/assets/be276adf-b634-4294-a22f-225a0cf9d274)

### 6. Saving the Report

After the request is processed, the generated report is saved to the database.

![Create Report](https://github.com/user-attachments/assets/5205d2a4-6dee-4dbe-9c66-50cde8af435e)

### 7. Verifying the Database Record

The following screenshot shows an example of a report record stored in the database.

![Example Report](https://github.com/user-attachments/assets/e7c2b327-ab3b-47db-9c70-a54d46838617)

## Conclusion

This project demonstrates how microservices can communicate asynchronously using RabbitMQ, run with Docker, and process report requests with database persistence.

Thank you for reading!
