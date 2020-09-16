# SampleEcommerce
This project created with n-tier layered architecture and MongoDB is used for storage.Also project include ```docker-compose``` file to up containers easyly  

## Installation

You can run project with docker.

```bash
docker-compose up
```

## Usage
```You can add product with endpoint at below```
|  | Product POST Request |
|--|--|
| URL | http://localhost:9393/api/products|
| Method | POST|
| Body |{"name": "Computer","description": "This is a computer","price": 500,"amount": 20,"sellEndDate": "2020-01-01T00:00:00Z"} |

```You can add product to basket with endpoint at below```
|  | Product POST Request |
|--|--|
| URL | http://localhost:9393/api/baskets|
| Method | POST|
| Body | {"productId" : "5f60eb41f349a63443f7c68d" , "amount" : 1} |

if your basket post body does not include amount property , amount = 1 is default

## Validation of post basket
1- When you add a product to basket with amount , Product has to be valid amount for stock size. 

2- SellEndDate of product that you want to add to basket must be greather than now.  



## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)
