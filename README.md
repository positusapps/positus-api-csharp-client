## Instantiating

````.NET
$client = new Client();
````
## Authentication

If you don't have an authentication token, [click here](https://studio.posit.us/minha-conta/api-tokens) to generate one.

````.NET
Client client = new Client(@"you-api-token", false);
````

## Sending Messages
The first step to be able to send messages is to specify the ID number of origin:

````.NET
client.numberId = "chave";
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



### Contact
````.NET
            List<ContactDetail> contactDetails = new List<ContactDetail>();
            
            List<Phone> phones = new List<Phone>();
            phones.Add(new Phone() { phone = "+55 11 2626-4234", type= "CELL", wa_id = "551126264234" });

            contactDetails.Add(new ContactDetail()
            {
                name = new Name() { first_name = "Positus Provider", formatted_name = "Positus Provider" },
                phones = phones
            });


            @Message message = client.sendContacts(new Contact()
            {
                contacts = contactDetails,
                to = "+999999999",
                type = "contacts"
            });

````

### Location
````.NET
            @Message message = client.sendLocation(new Location()
            {
                location = new LocationDetail()
                {
                    name = "Robbu brazil",
                    address = "Av. Angélica, 2530 - Bela Vista, São Paulo - SP, 01228-200",
                    longitude = -46.662787,
                    latitude = -23.553610
                },
                to = "+999999999",
                type = "location"
            });
````

### Location
````.NET

````


### HSM

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


### Template
````.NET

   List<Component> lstComponent = new List<Component>();
            Component itemComponent ;
            Parameter parameter ;

            List<Parameter> lstParameterHeader= new List<Parameter>();

            parameter = new Parameter();
            parameter.type = "image";
            parameter.image = new ImageLink() { link = "https://picsum.photos/200" };
            lstParameterHeader.Add(parameter);



            List<Parameter> lstParameterBody = new List<Parameter>();
            parameter = new Parameter();
            parameter.type = "text";
            parameter.text = "Helber";
            lstParameterBody .Add(parameter);

            parameter.type = "text";
            parameter.text = "Empresa X";
            lstParameterBody .Add(parameter);

            itemComponent = new Component();
            itemComponent.type = "body";
            itemComponent.parameters = lstParameterBody ;
            lstComponent .Add(itemComponent);


            itemComponent = new Component();
            itemComponent.type = "header";
            itemComponent.parameters = lstParameterHeader;
            lstComponent .Add(itemComponent);



            @Message message = client.sendTemplate(new Template()
            {

                template = new TemplateDetails()
                {
                    name = "your_template_name"
                ,
                    @namespace = "your_namespace"
                ,
                    language = new Language()
                    {
                        code = "pt_BR"
                ,
                        policy = "deterministic"
                    }
                ,
                    components = lstComponent 
                }
                      ,
                to = "+55999999999"
                      ,
                type = "template"
            });
