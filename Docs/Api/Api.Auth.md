# Buber Dinner API

- [Buber Dinner API](#buber-dinner-api)
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)

## Auth

### Register

```js
POST {{host}}/auth/register
```

#### Register Request

```json
{
  "firstName": "Thang",
  "lastName": "Nguyen",
  "email": "thangvhv99@gmail.com",
  "password": "123456"
}
```

#### Register Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a",
  "firstName": "Thang",
  "lastName": "Nguyen",
  "email": "thangvhv99@gmail.com",
  "password": "123456"
}
```

### Login

```js
POST {{host}}/auth/login
```

#### Login Request

```json
{
  "email": "thangvhv99@gmail.com",
  "password": "123456"
}
```

#### Login Response

```js
200 OK
```

```json
{
  "id": "d89c2d9a",
  "firstName": "Thang",
  "lastName": "Nguyen",
  "email": "thangvhv99@gmail.com",
  "token": "eyJhb.hbbQ"
}
```
