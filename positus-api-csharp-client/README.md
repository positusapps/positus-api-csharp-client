## Requirements

- .NET Standard 2.0

## Installing

Use Nugget to install it:
dotnet add package positus-api-csharp-client 


## Instantiating

````.NET
$client = new Client();
````

## Authentication

If you don't have an authentication token, [click here](https://studio.posit.us/minha-conta/api-tokens) to generate one.

````.NET
$client = new Client();

Client client = new Client(@"you-api-token",false);
````

## Sending Messages

The first step to be able to send messages is to specify the ID number of origin:

````.NET
client.numberId = "your-number-id";
````

Then send the message and wait for a response.

If you want to send a message using data on your own, you can use:

````NET
        @Message message = client.sendData(Object);
````

To check all the data that can be sent in each type of message, check the [WhatsApp Business documentation](https://developers.facebook.com/docs/whatsapp/api/messages).

If you prefer, we provide ready methods for each type of message.

### Text

````.NET
        @Message message = client.sendMessage(new Text()
            {
                text = new TextDetail() { body = "Olá Mundo" }
                                  ,
                to = "+5511941489395"
                                  ,
                type = "text"
            });
````



### Hsm

````.NET
            @Message message = client.sendHsm(new Hsm()
            {

                hsm = new HsmDetail()
                {
                    element_name = "xxxxxxx"
                ,
                    @namespace = "xxxxxxx"
                ,
                    language = new Language()
                    {
                        code = "pt_BR"
                ,
                        policy = "deterministic"
                    }
                ,
                    localizable_params = list
                }
                      ,
                to = "+999999999999"
                      ,
                type = "hsm"
            });
````
