# Web API For Maintaing Cloud Resources
## Purpose:
Create a library to create and maintain cloud infrastructure efficiently without needing to have deep knowledge about different cloud providers. This library will introduce APIs and abstractions that developers can use to design and implement cloud agnostic infrastructure.
## Requirements:
* **Phase #1:**
    * Supporting only virtual machines and database servers (database servers should support both MySQL and SQL Server).
    * Scalability for more resources (i.e. load balancers, elastic file storage etc.) at later stages.
    * To be able to create both Windows and Linux instances.
    * Create multiple infrastructures, for example create a UAT infrastructure for one project and a Test infrastructure for their internal team.
* The library should be .NET standard
* It should support creating and deleting infrastructures
* The library should have the implementation for a provider called IGS Cloud Services 
  > Note: IGS is an imaginary cloud provider in this assessment) 
  
  as the initial infrastructure provider but with an option to introduce new providers
* Output:
    * The output of creating an infrastructure should be a sub-directory in the provider directory with the same name as the infrastructure
    * A sub-directory for each resource type
    * For each resource there is a file containing the attributes of that resource should be created in the [infrastructure/resource type] directory.
	Example: IGS => UAT => VirtualMachine => UAT_SERVER.json => content: {property}
    * The delete API should accept the name of an infrastructure and delete all the associated resources
         * The implementation of deleting a resource is to delete the resource file on disk example delete UAT_SERVER.json
         * > **Important:** Do not delete the infrastructure folder. Dependency hierarchy should be followed, i.e. a virtual machine first should be deleted before deleting its hard disks.

# APIs:
* Supports only `application/json` or `application/xml` responses
  ## Cloud Provider
    * #### Create new Cloud Provider `/api/CloudProvider/create`
            
        * Request body example:
        
            `curl --location --request POST 'http://localhost:13965/api/CloudProvider/Create' \
            --header 'Content-Type: application/json'`
        
            ```json
                {
                  "Name": "IGN", //string - required
                  "Location": "Egypt" //string - required
                }
            ```
        
        * Response:
            * `200 - OK returns created cloud provider`
                ```json
                {
                    "cloudProvider": {
                        "name": "string",
                        "location": "string",
                        "address": "string",
                        "dateCreated": "string",
                        "dateModified": "string",
                        "createdBy": "string",
                        "modifiedBy": "string"
                    },
                    "operationStatus": 0, // 0 is Success and 1 is Failed
                    "description": "string"
                }
                ```
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
                ```json
                {
                  "Type": "string",
                  "Title": "string",
                  "Status": 0,
                  "Detail": "string",
                  "Instance": "string",
                  "Extensions": {}
                }
                ```
                
    * #### Delete new Cloud Provider `/api/CloudProvider/delete/{name}` 
         
        * **Request body example:**

            `curl --location --request DELETE 'http://localhost:13965/api/CloudProvider/delete/IGN'`
            
        * **Response:**
            * `200	(Success) Returns after successful deletion`
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
                ```json
                {
                  "Type": "string",
                  "Title": "string",
                  "Status": 0,
                  "Detail": "string",
                  "Instance": "string",
                  "Extensions": {}
                }
                ```
                
  ## Infrastructure
  
    * #### Create new Infrastructure  `/api/Infrastructure/{providerName}/create` 
            
        * **Request body example**
        
            `curl --location --request POST 'http://localhost:13965/api/Infrastructure/IGN/create' \
                  --header 'Content-Type: application/json' `
        
            ```json
                {
                  "Name": "UAT", //string - required
                  "Location": "Egypt" //string - required
                }
            ```
            
        * **Response:**
            * `200 - OK returns created Infrastructure`
                ```json
                {
                    "infrastructure": {
                        "cloudProvider": {
                            "name": "string",
                            "location": "string",
                            "address": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "name": "string",
                        "location": "string",
                        "address": "string",
                        "dateCreated": "string",
                        "dateModified": "string",
                        "createdBy": "string",
                        "modifiedBy": "string"
                    },
                    "operationStatus": 0,
                    "description": "string"
                }
                ```
            * 400 (BadRequest) In case of incorrect request parameters
            * 406 (Not Acceptable) In case of using setting response other than JSON or XML
             
    * #### Delete Infrastructure `/api/Infrastructure/{providerName}/delete/{name}`
        * **Request body example:**

            `curl --location --request DELETE 'http://localhost:13965/api/Infrastructure/IGN/delete/UAT'`
        
        * **Response:**
        
            * `200	(Success) Returns after successful deletion`
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
               
  ## Resources
  
    * #### Virtual Machine
        
        * #### Create new Virtual Machine `/api/Resource/{providerName}/{infrastructureName}/VirtualMachine/create`
            
            * **Request body example:**
            
                `curl --location --request POST 'http://localhost:13965/api/Resource/IGN/UAT/virtualmachine/create' \
                --header 'Content-Type: application/json'`
                
                ```json
                {
                  "Location": "string",
                  "HardwareProfile": {
                    "MemorySize": 0
                  },
                  "StorageProfile": {
                    "DiskInfo": "string"
                  },
                  "NetworkProfile": {
                    "PrivateIp": "string",
                    "PublicIp": "string",
                    "Dns": "string"
                  },
                  "AdditionalConfigurations": {
                    "additionalProp1": "string",
                    "additionalProp2": "string",
                    "additionalProp3": "string"
                  }
                }
                ```
        * **Response:**
            * `200 - OK returns created Virtual Machine`
                ```json
                {
                    "resource": {
                        "additionalConfigurations": {
                            "additionalProp1": "string",
                            "additionalProp2": "string",
                            "additionalProp3": "string"
                        },
                        "resourceType": 1, //1 VirtualMachine, 2 DataServer, 3 LoadBalancer ...
                        "infrastructureId": 0,
                        "hardwareProfileId": 0,
                        "storageProfileId": 0,
                        "networkProfileId": 0,
                        "infrastructure": {
                            "cloudProvider": {
                                "name": "string",
                                "location": "string",
                                "address": "string",
                                "dateCreated": "string",
                                "dateModified": "string",
                                "createdBy": "string",
                                "modifiedBy": "string"
                            },
                            "name": "string",
                            "location": "string",
                            "address": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "hardwareProfile": {
                            "memorySize": 0,
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "storageProfile": {
                            "diskInfo": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "networkProfile": {
                            "privateIp": "string",
                            "publicIp": "string",
                            "dns": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "name": "UAT_VirtualMachine",
                        "location": "string",
                        "address": "string",
                        "dateCreated": "string",
                        "dateModified": "string",
                        "createdBy": "string",
                        "modifiedBy": "string"
                    },
                    "operationStatus": 0,
                    "description": "string"
                }
                ```
                
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
            
    * ### Delete VirtualMachine `/api/Resource/{providerName}/{infrastructureName}/VirtualMachine/delete`
        * **Request body example:**

            `curl --location --request DELETE 'http://localhost:13965/api/Resource/IGN/UAT/VirtualMachine/delete'`
        
        * **Response:**
            * `200	(Success) Returns after successful deletion`
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
            
            
    * #### Data Server
        
        * ### Create new Data Server `/api/Resource/{providerName}/{infrastructureName}/DataServer/delete`
            
            * **Request body example:**
            
                `curl --location --request POST 'http://localhost:13965/api/Resource/IGN/UAT/DataServer/create' \
                --header 'Content-Type: application/json'`
                
                ```json
                {
                  "Location": "string",
                  "HardwareProfile": {
                    "MemorySize": 0
                  },
                  "StorageProfile": {
                    "DiskInfo": "string"
                  },
                  "NetworkProfile": {
                    "PrivateIp": "string",
                    "PublicIp": "string",
                    "Dns": "string"
                  },
                  "AdditionalConfigurations": {
                    "additionalProp1": "string",
                    "additionalProp2": "string",
                    "additionalProp3": "string"
                  },
                  "DbType": 1,
                  "Version": "string"
                }
                {
                  "Location": "string",
                  "HardwareProfile": {
                    "MemorySize": 0
                  },
                  "StorageProfile": {
                    "DiskInfo": "string"
                  },
                  "NetworkProfile": {
                    "PrivateIp": "string",
                    "PublicIp": "string",
                    "Dns": "string"
                  },
                  "AdditionalConfigurations": {
                    "additionalProp1": "string",
                    "additionalProp2": "string",
                    "additionalProp3": "string"
                  },
                  "DbType": 1, //1 SQL and 2 MySQL
                  "Version": "string"
                }
                ```
            
            
        * **Response:**
            * `200 - OK returns created Virtual Machine`
                ```json
                {
                    "dbType": 1, //1 SQL and 2 MySQL
                    "version": "string",
                    "resource": {
                        "additionalConfigurations": {
                            "additionalProp1": "string",
                            "additionalProp2": "string",
                            "additionalProp3": "string"
                        },
                        "resourceType": 1,
                        "infrastructureId": 0,
                        "hardwareProfileId": 0,
                        "storageProfileId": 0,
                        "networkProfileId": 0,
                        "infrastructure": {
                            "cloudProvider": {
                                "name": "string",
                                "location": "string",
                                "address": "string",
                                "dateCreated": "string",
                                "dateModified": "string",
                                "createdBy": "string",
                                "modifiedBy": "string"
                            },
                            "name": "UAT",
                            "location": "string",
                            "address": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "hardwareProfile": {
                            "memorySize": 100,
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "storageProfile": {
                            "diskInfo": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "networkProfile": {
                            "privateIp": "string",
                            "publicIp": "string",
                            "dns": "string",
                            "dateCreated": "string",
                            "dateModified": "string",
                            "createdBy": "string",
                            "modifiedBy": "string"
                        },
                        "name": "UAT_VirtualMachine",
                        "location": "string",
                        "address": "string",
                        "dateCreated": "2020-12-07T13:55:53.4972399+02:00",
                        "dateModified": "2020-12-07T13:55:53.4972399+02:00",
                        "createdBy": "string",
                        "modifiedBy": "string"
                    },
                    "operationStatus": 0,
                    "description": "string"
                }
                ```
                
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
            
    * ### Delete VirtualMachine `/api/Resource/{providerName}/{infrastructureName}/DataServer/delete`
        * **Request body example:**

            `curl --location --request DELETE 'http://localhost:13965/api/Resource/IGN/UAT/DataServer/delete'`
        
        * **Response:**
            * `200	(Success) Returns after successful deletion`
            * `400 (BadRequest) In case of incorrect request parameters`
            * `406 (Not Acceptable) In case of using setting response other than JSON or XML`
            
