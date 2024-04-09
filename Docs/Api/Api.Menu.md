# Buber Dinner API

## Menu

### Create Menu

```js
POST / hosts / { hostId } / menus;
```

#### Create Menu Request

```json
{
  "name": "Yummy Menu",
  "description": "A menu with yummy food",
  "sections": [
    {
      "name": "Appetizers",
      "description": "Starters",
      "items": [
        {
          "name": "Fried Pickles",
          "description": "Deep fried pickles"
        }
      ]
    }
  ]
}
```

#### Create Menu Response

```js
201 OK
```

```json
{
  "id": "00000000-0000-0000-0000-0000000000000",
  "name": "Yummy Menu",
  "description": "A menu with yummy food",
  "sections": [
    {
      "id": "00000000-0000-0000-0000-0000000000000",
      "name": "Appetizers",
      "description": "Starters",
      "items": [
        {
          "id": "00000000-0000-0000-0000-0000000000000",
          "name": "Fried Pickles",
          "description": "Deep fried pickles"
        }
      ]
    }
  ],
  "hostId": "00000000-0000-0000-0000-0000000000000",
  "dinnerIds": ["00000000-0000-0000-0000-0000000000000"],
  "menuReviewIds": ["00000000-0000-0000-0000-0000000000000"],
  "createdDateTime": "2024-01-01T00:00:00.0000000Z",
  "updatedDateTime": "2024-01-01T00:00:00.0000000Z"
}
```
