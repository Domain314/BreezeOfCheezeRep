// GENERATED AUTOMATICALLY FROM 'Assets/Input/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Crosshair"",
            ""id"": ""a7450094-1646-4b2e-b16f-14a673be8ad9"",
            ""actions"": [
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""18466adf-3128-4c1a-8478-d6f01b58be84"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""0e6145fa-aecd-4290-916c-81d1a7ec7b03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveUp"",
                    ""type"": ""Button"",
                    ""id"": ""16d00549-98ad-4378-98a2-ec6fafeb7e60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveDown"",
                    ""type"": ""Button"",
                    ""id"": ""39df64f4-019d-484d-bb1a-801adeca9858"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Space"",
                    ""type"": ""Button"",
                    ""id"": ""44cab19c-9582-48ee-b259-4b4a760c80e3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Esc"",
                    ""type"": ""Button"",
                    ""id"": ""443b85dc-3c1f-4af4-94a3-bad1d22a80b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_qKey"",
                    ""type"": ""Button"",
                    ""id"": ""888e0097-1885-48b3-abcd-cd52bb129abc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_wKey"",
                    ""type"": ""Button"",
                    ""id"": ""99e8d074-96f2-46fc-a671-63801acc88df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_eKey"",
                    ""type"": ""Button"",
                    ""id"": ""6c61719a-d375-4d70-83f1-f18dfbf23b90"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_rKey"",
                    ""type"": ""Button"",
                    ""id"": ""9dfb1c0d-8067-4d6b-82cc-13ff5e428b55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_tKey"",
                    ""type"": ""Button"",
                    ""id"": ""8c7e9c9d-6267-4151-bc83-75f377558019"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_yKez"",
                    ""type"": ""Button"",
                    ""id"": ""344296b8-6119-46d1-b605-9250b0b5abb5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_uKey"",
                    ""type"": ""Button"",
                    ""id"": ""6cf5e1f4-d4b3-44aa-801f-fdc094268bff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_iKey"",
                    ""type"": ""Button"",
                    ""id"": ""99835a44-bfa3-4052-b6b9-437be85050d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_oKey"",
                    ""type"": ""Button"",
                    ""id"": ""2d9c0e52-d28a-4b8b-9546-a7c43ae79d15"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_pKey"",
                    ""type"": ""Button"",
                    ""id"": ""9300a771-5469-494e-bd40-1628c1d5c86d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_ueKey"",
                    ""type"": ""Button"",
                    ""id"": ""c37e983b-b089-4283-92c9-8358f989fe05"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_ue2Key"",
                    ""type"": ""Button"",
                    ""id"": ""56ae8ea9-ec3d-449a-bae5-a98ecc6168f4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Enter"",
                    ""type"": ""Button"",
                    ""id"": ""99bc0c53-9056-4602-8e6f-12cd54068746"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_aKey"",
                    ""type"": ""Button"",
                    ""id"": ""094f5e48-e3fe-47e9-b380-a7a4d363d41f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_sKey"",
                    ""type"": ""Button"",
                    ""id"": ""e1292df9-7eef-4abd-b93a-2c85d8f47e7b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_dKey"",
                    ""type"": ""Button"",
                    ""id"": ""772fe40d-ebef-48f7-a979-133531f07644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_fKey"",
                    ""type"": ""Button"",
                    ""id"": ""6479a5c4-436f-4a47-920c-c09670e10311"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_gKey"",
                    ""type"": ""Button"",
                    ""id"": ""9b50e60e-99db-4719-be93-8641326a21f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_hKey"",
                    ""type"": ""Button"",
                    ""id"": ""ca1037e5-2f20-4419-b810-09cb6bcb5873"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_jKey"",
                    ""type"": ""Button"",
                    ""id"": ""1b77ae9e-f496-48b4-b9e7-993ce37e3544"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_kKey"",
                    ""type"": ""Button"",
                    ""id"": ""658b48c7-a5db-4cb7-9891-b4463be20f1f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_lKey"",
                    ""type"": ""Button"",
                    ""id"": ""42046c1a-01d2-4b77-a172-e656ae7e0fec"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_semicolonKey"",
                    ""type"": ""Button"",
                    ""id"": ""e7fe28ec-af68-474d-84a2-9d36575044bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_aposKey"",
                    ""type"": ""Button"",
                    ""id"": ""77a9f47b-229c-4429-8f6f-3d6211d3cdb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_hashKey"",
                    ""type"": ""Button"",
                    ""id"": ""316d3a10-b120-406f-860d-0383df2a6592"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_backslashKey"",
                    ""type"": ""Button"",
                    ""id"": ""7fad7e61-6aa9-443b-bf2e-0fb243808204"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_zKey"",
                    ""type"": ""Button"",
                    ""id"": ""3ae62c52-31ee-459e-9c4e-ea115b8be391"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_xKey"",
                    ""type"": ""Button"",
                    ""id"": ""6ee3537a-f66c-4da3-be00-376ca7c24926"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_cKey"",
                    ""type"": ""Button"",
                    ""id"": ""a874c740-8e46-4a48-8b8d-356217fd1c7d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_vKey"",
                    ""type"": ""Button"",
                    ""id"": ""2bb9cb93-cc87-4219-8e26-5d98536b8018"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_bKey"",
                    ""type"": ""Button"",
                    ""id"": ""9cfde7d5-f5ef-45c8-9be8-7fbb09f2341c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_nKey"",
                    ""type"": ""Button"",
                    ""id"": ""3f987f19-0459-4a08-a7e5-7215fd4efcbc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_mKey"",
                    ""type"": ""Button"",
                    ""id"": ""fe8de5ce-17fd-4828-8094-5e20667f8649"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_colonKey"",
                    ""type"": ""Button"",
                    ""id"": ""0450f1b6-6e78-4458-8a5d-c4319d50f1dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_dotKey"",
                    ""type"": ""Button"",
                    ""id"": ""6aa42e98-6b6d-4235-ab64-82a6ca6608b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_slashKey"",
                    ""type"": ""Button"",
                    ""id"": ""dc25c42d-4b68-43ec-96c6-f7af4eddddb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_0Key"",
                    ""type"": ""Button"",
                    ""id"": ""50a78aa7-79ee-49f4-81c1-f79001fe2226"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_1Key"",
                    ""type"": ""Button"",
                    ""id"": ""484d15e5-c7e7-4ed1-9f2f-e003fd0f2b1c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_2Key"",
                    ""type"": ""Button"",
                    ""id"": ""a481fb2a-732a-4fdd-ba3a-d0b208ed4069"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_3Key"",
                    ""type"": ""Button"",
                    ""id"": ""d8d97821-0ef1-4764-9818-d2441c2f6be5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_4Key"",
                    ""type"": ""Button"",
                    ""id"": ""773dc080-cb17-419f-b5b7-c79b40381e9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_5Key"",
                    ""type"": ""Button"",
                    ""id"": ""35055ae7-6f20-4781-ad12-7248bbf715ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_6Key"",
                    ""type"": ""Button"",
                    ""id"": ""da3a48bf-0fcd-4859-9ead-c68116adade7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_7Key"",
                    ""type"": ""Button"",
                    ""id"": ""1d68fac2-3e72-4fb2-8f18-e594ad658008"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_8Key"",
                    ""type"": ""Button"",
                    ""id"": ""128e3665-5222-4522-8704-7fddab490296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""_9Key"",
                    ""type"": ""Button"",
                    ""id"": ""4b3bf2b5-b4e8-49c5-be2b-cb52ebbac2a6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""30a3a9f8-212a-470f-aecc-1e445d40561b"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ab27f12-32ec-4697-b7ee-7f1dd59d41ce"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c0eb7be0-e2ba-4be3-b191-45a5b1b5a7d7"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e09f0863-c62c-47e9-a179-70d640e80192"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e85da85b-b67f-40c1-a31c-771d8f2be193"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b3381ce-2183-4844-ac0f-88ce34a43eef"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""be0a5bc5-632d-4ed0-a10c-63b49ae23d90"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc45eeb8-b89c-4235-bdc0-b3f51ad00fb3"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""MoveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b3719a4c-d6cd-4484-b1a4-2a68525dac77"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Space"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1079cead-3505-44d9-9a5b-6f25fb17b4a1"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Esc"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6c70533-2893-47be-99fc-505af449f454"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_qKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afb86144-1969-4f87-9bf7-ac536795cace"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_wKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6063781f-4fe8-4135-b898-5fdde67a731c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_eKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f720cd3-df74-4d6d-ac13-fdd9f5acdae7"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_rKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afff2ebe-ed88-4b87-95d4-9a4462fbe051"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_tKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1e83449-9ccd-4d4f-8a07-569b29802f52"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_uKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""67fece57-fc72-48e6-9b02-8943cc054878"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_iKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45e99bdd-8c85-4586-bb68-785191e3ae7c"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_oKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cff87684-c257-46a0-8767-481bb062411e"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_pKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2822c4d4-6674-4606-9a9c-7f67981d4509"",
                    ""path"": ""<Keyboard>/leftBracket"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_ueKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d717ba17-5618-428f-b7c5-51e04ba20cbf"",
                    ""path"": ""<Keyboard>/rightBracket"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_ue2Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12800de9-bacc-47be-8784-4eb7746449b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_aKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3642f111-0530-4bb2-81e2-45f8d6f238da"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_sKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28a4cd90-7c91-4bf3-8447-5e3f1507387a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_dKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd359121-867c-453e-a82e-bf4a71ccfb56"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_fKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e3ba8d9-1e17-45e8-839e-365c4d0e9d08"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_gKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f9e23635-3245-45be-989a-1610975c0fc9"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_hKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f4b8389d-d500-4bb6-b6a1-fa2a72e2708d"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_jKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6d0616f-0c61-4d35-984d-176f34adab6a"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_kKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7ffc00af-1d19-4b26-82f8-bde7c89861dc"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_lKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30218b15-c9c0-4423-8dc8-11492303d4fe"",
                    ""path"": ""<Keyboard>/semicolon"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_semicolonKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11a80091-9bea-43c8-9c05-46c7e12a4096"",
                    ""path"": ""<Keyboard>/quote"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_aposKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""25c89344-2404-4524-b5b4-6d66723a427b"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_hashKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5efb893-7bac-46ef-82d2-c0dca06027df"",
                    ""path"": ""<Keyboard>/backslash"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_backslashKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""504606f2-ddcf-42f6-b8e7-b584a124e33e"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_xKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4839bec4-f24c-471a-b255-9da518115a6d"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_cKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5233b38d-23e7-4350-a7d5-bf43aedc9add"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_vKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c863410-e932-490c-abdb-e4595da8b8e8"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_bKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ed7479b-3133-4e9d-99c5-0159de463436"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_nKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2d2b443-21ac-4250-8583-1179b7777864"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_yKez"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""229c2c5a-4610-4fea-a623-5c73361b9842"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e93c2d51-6cb7-46a5-a016-04d697318807"",
                    ""path"": ""<Keyboard>/numpadEnter"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Enter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dae06338-a152-459d-b3e9-bcf149ed967c"",
                    ""path"": ""<Keyboard>/z"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_zKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ba328004-eb1b-4598-83c2-2a8bcb7d8a12"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_mKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb3c4aa7-1ead-45a9-a44b-a1fefa6a4e5c"",
                    ""path"": ""<Keyboard>/comma"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_colonKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5af2739-8e70-4f69-b23d-cd99f3c408b5"",
                    ""path"": ""<Keyboard>/period"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_dotKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""969d7dcb-59e0-4ac3-87c7-eb70ccccfd59"",
                    ""path"": ""<Keyboard>/slash"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_slashKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ecf7b66-96dc-4fef-a508-5a4d39d31095"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_0Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""197af4c0-d903-4abe-97a7-e79c6d340f8b"",
                    ""path"": ""<Keyboard>/numpad0"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_0Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1615449c-b859-42fe-bf6a-d9d55888a144"",
                    ""path"": ""<Keyboard>/9"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_9Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""394965a6-9501-45dc-8b58-9d49ea6916e8"",
                    ""path"": ""<Keyboard>/numpad9"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_9Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ff85f54f-562f-4090-91d9-61dbafc7f527"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_1Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c347c7e-51da-4e2a-9c22-ac410539cf20"",
                    ""path"": ""<Keyboard>/numpad1"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_1Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ac3e226-bd27-4eaf-8d31-630ebd52364d"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_2Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8636473c-03d6-41c7-a046-4ed1433731a9"",
                    ""path"": ""<Keyboard>/numpad2"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_2Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d7aea0cf-91a7-4f95-9cfa-5de4e749473c"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_3Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7d88625-a287-4059-b04b-ec1d275305cd"",
                    ""path"": ""<Keyboard>/numpad3"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_3Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e686dd6-a78f-4ae2-93f5-cf87b5cee7db"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_4Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca283942-c394-4f49-bd75-95ae9d8cfe63"",
                    ""path"": ""<Keyboard>/numpad4"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_4Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4135951a-4b54-4b48-ba40-51d2a4d6fd75"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_5Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""14489a54-602e-43cd-864e-442e27e0c832"",
                    ""path"": ""<Keyboard>/numpad5"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_5Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12e982bb-4d20-4b01-b3af-0d2df168a944"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_6Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50aecbf9-77f4-4207-8864-7d1282469700"",
                    ""path"": ""<Keyboard>/numpad6"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_6Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8efe4aa-ecaf-4b66-b7cd-df5a3907b5f4"",
                    ""path"": ""<Keyboard>/7"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_7Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f396babd-0ff4-4fd0-8088-84763c33c088"",
                    ""path"": ""<Keyboard>/numpad7"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_7Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fab6e532-978c-4323-a2a8-0b98838f2da7"",
                    ""path"": ""<Keyboard>/8"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_8Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb8b91e7-265c-4117-bd3b-f92e64a80be7"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""_8Key"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""70865ee8-ce6e-4a00-8fae-436509721285"",
            ""actions"": [
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""1f6fbac3-6155-4fbc-9cbc-ac6e4fd4f0dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ScrollWheel"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b18cdf56-214e-4c87-9d63-4ca293fc156a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d0534664-39cf-4147-aa62-8807c84d626d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""197ed4ff-c60f-4eb2-8dce-2fab78b88d6b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDevicePosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""a7644b9d-8c29-4f7e-b447-0ddacd26f736"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TrackedDeviceOrientation"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3615c5f7-bf55-44a7-975d-217c51cb1299"",
                    ""expectedControlType"": ""Quaternion"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""9f5ce09c-6681-497a-91b5-85c8a05806cb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""a52207d2-c10f-40ff-8244-90d364326d6f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4535ca43-9202-4176-837e-716445947804"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7d974321-95d2-43c0-a31c-a35e64c74606"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2e71ff99-900e-4a3c-8610-0089a3626e5b"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8afb5ca5-651b-4201-a110-31a7d60a742b"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""ScrollWheel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27ad1915-7484-4f21-b9f5-158132003c08"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""MiddleClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a68622a4-a3b3-46c1-859a-24aa63764cbc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard&Mouse"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cb5eb9a-8aab-4b5e-82e6-247e061cf816"",
                    ""path"": ""<XRController>/devicePosition"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDevicePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6e501e05-a579-4d09-a964-3782f8ff4127"",
                    ""path"": ""<XRController>/deviceRotation"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XR"",
                    ""action"": ""TrackedDeviceOrientation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""314bb7bd-fd12-418f-961a-0c7354629e79"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0b6ea938-b519-4764-9759-5eeed690cea8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e12914f5-347c-4b8a-925e-ae2b7fed4317"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c691adaf-4815-4484-b880-b4f0381070c3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8223ef93-54fb-43d3-8edd-eb440dac5dd6"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bd852585-08b7-4864-9fdc-f7621d02b231"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""50934f57-dc07-43f7-9333-28eca15778d1"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""47b73383-4a5a-4a84-b9c3-9fd0c80c9bd3"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""795418cb-12f0-40ed-8151-8431f00e082d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a3c5f1b7-c174-4c5f-9442-f3e7ace49a14"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a70edc0f-1c62-44b3-85e0-ae733dc00120"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33aa272d-0fbb-4a7f-b061-4fa913572097"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FirstControlScheme"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""FirstControlScheme"",
            ""bindingGroup"": ""FirstControlScheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Crosshair
        m_Crosshair = asset.FindActionMap("Crosshair", throwIfNotFound: true);
        m_Crosshair_MoveLeft = m_Crosshair.FindAction("MoveLeft", throwIfNotFound: true);
        m_Crosshair_MoveRight = m_Crosshair.FindAction("MoveRight", throwIfNotFound: true);
        m_Crosshair_MoveUp = m_Crosshair.FindAction("MoveUp", throwIfNotFound: true);
        m_Crosshair_MoveDown = m_Crosshair.FindAction("MoveDown", throwIfNotFound: true);
        m_Crosshair_Space = m_Crosshair.FindAction("Space", throwIfNotFound: true);
        m_Crosshair_Esc = m_Crosshair.FindAction("Esc", throwIfNotFound: true);
        m_Crosshair__qKey = m_Crosshair.FindAction("_qKey", throwIfNotFound: true);
        m_Crosshair__wKey = m_Crosshair.FindAction("_wKey", throwIfNotFound: true);
        m_Crosshair__eKey = m_Crosshair.FindAction("_eKey", throwIfNotFound: true);
        m_Crosshair__rKey = m_Crosshair.FindAction("_rKey", throwIfNotFound: true);
        m_Crosshair__tKey = m_Crosshair.FindAction("_tKey", throwIfNotFound: true);
        m_Crosshair__yKez = m_Crosshair.FindAction("_yKez", throwIfNotFound: true);
        m_Crosshair__uKey = m_Crosshair.FindAction("_uKey", throwIfNotFound: true);
        m_Crosshair__iKey = m_Crosshair.FindAction("_iKey", throwIfNotFound: true);
        m_Crosshair__oKey = m_Crosshair.FindAction("_oKey", throwIfNotFound: true);
        m_Crosshair__pKey = m_Crosshair.FindAction("_pKey", throwIfNotFound: true);
        m_Crosshair__ueKey = m_Crosshair.FindAction("_ueKey", throwIfNotFound: true);
        m_Crosshair__ue2Key = m_Crosshair.FindAction("_ue2Key", throwIfNotFound: true);
        m_Crosshair_Enter = m_Crosshair.FindAction("Enter", throwIfNotFound: true);
        m_Crosshair__aKey = m_Crosshair.FindAction("_aKey", throwIfNotFound: true);
        m_Crosshair__sKey = m_Crosshair.FindAction("_sKey", throwIfNotFound: true);
        m_Crosshair__dKey = m_Crosshair.FindAction("_dKey", throwIfNotFound: true);
        m_Crosshair__fKey = m_Crosshair.FindAction("_fKey", throwIfNotFound: true);
        m_Crosshair__gKey = m_Crosshair.FindAction("_gKey", throwIfNotFound: true);
        m_Crosshair__hKey = m_Crosshair.FindAction("_hKey", throwIfNotFound: true);
        m_Crosshair__jKey = m_Crosshair.FindAction("_jKey", throwIfNotFound: true);
        m_Crosshair__kKey = m_Crosshair.FindAction("_kKey", throwIfNotFound: true);
        m_Crosshair__lKey = m_Crosshair.FindAction("_lKey", throwIfNotFound: true);
        m_Crosshair__semicolonKey = m_Crosshair.FindAction("_semicolonKey", throwIfNotFound: true);
        m_Crosshair__aposKey = m_Crosshair.FindAction("_aposKey", throwIfNotFound: true);
        m_Crosshair__hashKey = m_Crosshair.FindAction("_hashKey", throwIfNotFound: true);
        m_Crosshair__backslashKey = m_Crosshair.FindAction("_backslashKey", throwIfNotFound: true);
        m_Crosshair__zKey = m_Crosshair.FindAction("_zKey", throwIfNotFound: true);
        m_Crosshair__xKey = m_Crosshair.FindAction("_xKey", throwIfNotFound: true);
        m_Crosshair__cKey = m_Crosshair.FindAction("_cKey", throwIfNotFound: true);
        m_Crosshair__vKey = m_Crosshair.FindAction("_vKey", throwIfNotFound: true);
        m_Crosshair__bKey = m_Crosshair.FindAction("_bKey", throwIfNotFound: true);
        m_Crosshair__nKey = m_Crosshair.FindAction("_nKey", throwIfNotFound: true);
        m_Crosshair__mKey = m_Crosshair.FindAction("_mKey", throwIfNotFound: true);
        m_Crosshair__colonKey = m_Crosshair.FindAction("_colonKey", throwIfNotFound: true);
        m_Crosshair__dotKey = m_Crosshair.FindAction("_dotKey", throwIfNotFound: true);
        m_Crosshair__slashKey = m_Crosshair.FindAction("_slashKey", throwIfNotFound: true);
        m_Crosshair__0Key = m_Crosshair.FindAction("_0Key", throwIfNotFound: true);
        m_Crosshair__1Key = m_Crosshair.FindAction("_1Key", throwIfNotFound: true);
        m_Crosshair__2Key = m_Crosshair.FindAction("_2Key", throwIfNotFound: true);
        m_Crosshair__3Key = m_Crosshair.FindAction("_3Key", throwIfNotFound: true);
        m_Crosshair__4Key = m_Crosshair.FindAction("_4Key", throwIfNotFound: true);
        m_Crosshair__5Key = m_Crosshair.FindAction("_5Key", throwIfNotFound: true);
        m_Crosshair__6Key = m_Crosshair.FindAction("_6Key", throwIfNotFound: true);
        m_Crosshair__7Key = m_Crosshair.FindAction("_7Key", throwIfNotFound: true);
        m_Crosshair__8Key = m_Crosshair.FindAction("_8Key", throwIfNotFound: true);
        m_Crosshair__9Key = m_Crosshair.FindAction("_9Key", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Cancel = m_UI.FindAction("Cancel", throwIfNotFound: true);
        m_UI_ScrollWheel = m_UI.FindAction("ScrollWheel", throwIfNotFound: true);
        m_UI_MiddleClick = m_UI.FindAction("MiddleClick", throwIfNotFound: true);
        m_UI_RightClick = m_UI.FindAction("RightClick", throwIfNotFound: true);
        m_UI_TrackedDevicePosition = m_UI.FindAction("TrackedDevicePosition", throwIfNotFound: true);
        m_UI_TrackedDeviceOrientation = m_UI.FindAction("TrackedDeviceOrientation", throwIfNotFound: true);
        m_UI_Navigate = m_UI.FindAction("Navigate", throwIfNotFound: true);
        m_UI_Submit = m_UI.FindAction("Submit", throwIfNotFound: true);
        m_UI_Point = m_UI.FindAction("Point", throwIfNotFound: true);
        m_UI_Click = m_UI.FindAction("Click", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Crosshair
    private readonly InputActionMap m_Crosshair;
    private ICrosshairActions m_CrosshairActionsCallbackInterface;
    private readonly InputAction m_Crosshair_MoveLeft;
    private readonly InputAction m_Crosshair_MoveRight;
    private readonly InputAction m_Crosshair_MoveUp;
    private readonly InputAction m_Crosshair_MoveDown;
    private readonly InputAction m_Crosshair_Space;
    private readonly InputAction m_Crosshair_Esc;
    private readonly InputAction m_Crosshair__qKey;
    private readonly InputAction m_Crosshair__wKey;
    private readonly InputAction m_Crosshair__eKey;
    private readonly InputAction m_Crosshair__rKey;
    private readonly InputAction m_Crosshair__tKey;
    private readonly InputAction m_Crosshair__yKez;
    private readonly InputAction m_Crosshair__uKey;
    private readonly InputAction m_Crosshair__iKey;
    private readonly InputAction m_Crosshair__oKey;
    private readonly InputAction m_Crosshair__pKey;
    private readonly InputAction m_Crosshair__ueKey;
    private readonly InputAction m_Crosshair__ue2Key;
    private readonly InputAction m_Crosshair_Enter;
    private readonly InputAction m_Crosshair__aKey;
    private readonly InputAction m_Crosshair__sKey;
    private readonly InputAction m_Crosshair__dKey;
    private readonly InputAction m_Crosshair__fKey;
    private readonly InputAction m_Crosshair__gKey;
    private readonly InputAction m_Crosshair__hKey;
    private readonly InputAction m_Crosshair__jKey;
    private readonly InputAction m_Crosshair__kKey;
    private readonly InputAction m_Crosshair__lKey;
    private readonly InputAction m_Crosshair__semicolonKey;
    private readonly InputAction m_Crosshair__aposKey;
    private readonly InputAction m_Crosshair__hashKey;
    private readonly InputAction m_Crosshair__backslashKey;
    private readonly InputAction m_Crosshair__zKey;
    private readonly InputAction m_Crosshair__xKey;
    private readonly InputAction m_Crosshair__cKey;
    private readonly InputAction m_Crosshair__vKey;
    private readonly InputAction m_Crosshair__bKey;
    private readonly InputAction m_Crosshair__nKey;
    private readonly InputAction m_Crosshair__mKey;
    private readonly InputAction m_Crosshair__colonKey;
    private readonly InputAction m_Crosshair__dotKey;
    private readonly InputAction m_Crosshair__slashKey;
    private readonly InputAction m_Crosshair__0Key;
    private readonly InputAction m_Crosshair__1Key;
    private readonly InputAction m_Crosshair__2Key;
    private readonly InputAction m_Crosshair__3Key;
    private readonly InputAction m_Crosshair__4Key;
    private readonly InputAction m_Crosshair__5Key;
    private readonly InputAction m_Crosshair__6Key;
    private readonly InputAction m_Crosshair__7Key;
    private readonly InputAction m_Crosshair__8Key;
    private readonly InputAction m_Crosshair__9Key;
    public struct CrosshairActions
    {
        private @InputMaster m_Wrapper;
        public CrosshairActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveLeft => m_Wrapper.m_Crosshair_MoveLeft;
        public InputAction @MoveRight => m_Wrapper.m_Crosshair_MoveRight;
        public InputAction @MoveUp => m_Wrapper.m_Crosshair_MoveUp;
        public InputAction @MoveDown => m_Wrapper.m_Crosshair_MoveDown;
        public InputAction @Space => m_Wrapper.m_Crosshair_Space;
        public InputAction @Esc => m_Wrapper.m_Crosshair_Esc;
        public InputAction @_qKey => m_Wrapper.m_Crosshair__qKey;
        public InputAction @_wKey => m_Wrapper.m_Crosshair__wKey;
        public InputAction @_eKey => m_Wrapper.m_Crosshair__eKey;
        public InputAction @_rKey => m_Wrapper.m_Crosshair__rKey;
        public InputAction @_tKey => m_Wrapper.m_Crosshair__tKey;
        public InputAction @_yKez => m_Wrapper.m_Crosshair__yKez;
        public InputAction @_uKey => m_Wrapper.m_Crosshair__uKey;
        public InputAction @_iKey => m_Wrapper.m_Crosshair__iKey;
        public InputAction @_oKey => m_Wrapper.m_Crosshair__oKey;
        public InputAction @_pKey => m_Wrapper.m_Crosshair__pKey;
        public InputAction @_ueKey => m_Wrapper.m_Crosshair__ueKey;
        public InputAction @_ue2Key => m_Wrapper.m_Crosshair__ue2Key;
        public InputAction @Enter => m_Wrapper.m_Crosshair_Enter;
        public InputAction @_aKey => m_Wrapper.m_Crosshair__aKey;
        public InputAction @_sKey => m_Wrapper.m_Crosshair__sKey;
        public InputAction @_dKey => m_Wrapper.m_Crosshair__dKey;
        public InputAction @_fKey => m_Wrapper.m_Crosshair__fKey;
        public InputAction @_gKey => m_Wrapper.m_Crosshair__gKey;
        public InputAction @_hKey => m_Wrapper.m_Crosshair__hKey;
        public InputAction @_jKey => m_Wrapper.m_Crosshair__jKey;
        public InputAction @_kKey => m_Wrapper.m_Crosshair__kKey;
        public InputAction @_lKey => m_Wrapper.m_Crosshair__lKey;
        public InputAction @_semicolonKey => m_Wrapper.m_Crosshair__semicolonKey;
        public InputAction @_aposKey => m_Wrapper.m_Crosshair__aposKey;
        public InputAction @_hashKey => m_Wrapper.m_Crosshair__hashKey;
        public InputAction @_backslashKey => m_Wrapper.m_Crosshair__backslashKey;
        public InputAction @_zKey => m_Wrapper.m_Crosshair__zKey;
        public InputAction @_xKey => m_Wrapper.m_Crosshair__xKey;
        public InputAction @_cKey => m_Wrapper.m_Crosshair__cKey;
        public InputAction @_vKey => m_Wrapper.m_Crosshair__vKey;
        public InputAction @_bKey => m_Wrapper.m_Crosshair__bKey;
        public InputAction @_nKey => m_Wrapper.m_Crosshair__nKey;
        public InputAction @_mKey => m_Wrapper.m_Crosshair__mKey;
        public InputAction @_colonKey => m_Wrapper.m_Crosshair__colonKey;
        public InputAction @_dotKey => m_Wrapper.m_Crosshair__dotKey;
        public InputAction @_slashKey => m_Wrapper.m_Crosshair__slashKey;
        public InputAction @_0Key => m_Wrapper.m_Crosshair__0Key;
        public InputAction @_1Key => m_Wrapper.m_Crosshair__1Key;
        public InputAction @_2Key => m_Wrapper.m_Crosshair__2Key;
        public InputAction @_3Key => m_Wrapper.m_Crosshair__3Key;
        public InputAction @_4Key => m_Wrapper.m_Crosshair__4Key;
        public InputAction @_5Key => m_Wrapper.m_Crosshair__5Key;
        public InputAction @_6Key => m_Wrapper.m_Crosshair__6Key;
        public InputAction @_7Key => m_Wrapper.m_Crosshair__7Key;
        public InputAction @_8Key => m_Wrapper.m_Crosshair__8Key;
        public InputAction @_9Key => m_Wrapper.m_Crosshair__9Key;
        public InputActionMap Get() { return m_Wrapper.m_Crosshair; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CrosshairActions set) { return set.Get(); }
        public void SetCallbacks(ICrosshairActions instance)
        {
            if (m_Wrapper.m_CrosshairActionsCallbackInterface != null)
            {
                @MoveLeft.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveLeft;
                @MoveLeft.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveLeft;
                @MoveRight.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveRight;
                @MoveRight.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveRight;
                @MoveRight.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveRight;
                @MoveUp.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveUp;
                @MoveUp.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveUp;
                @MoveUp.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveUp;
                @MoveDown.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveDown;
                @MoveDown.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveDown;
                @MoveDown.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnMoveDown;
                @Space.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnSpace;
                @Space.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnSpace;
                @Space.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnSpace;
                @Esc.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEsc;
                @_qKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_qKey;
                @_qKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_qKey;
                @_qKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_qKey;
                @_wKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_wKey;
                @_wKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_wKey;
                @_wKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_wKey;
                @_eKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_eKey;
                @_eKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_eKey;
                @_eKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_eKey;
                @_rKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_rKey;
                @_rKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_rKey;
                @_rKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_rKey;
                @_tKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_tKey;
                @_tKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_tKey;
                @_tKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_tKey;
                @_yKez.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_yKez;
                @_yKez.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_yKez;
                @_yKez.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_yKez;
                @_uKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_uKey;
                @_uKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_uKey;
                @_uKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_uKey;
                @_iKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_iKey;
                @_iKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_iKey;
                @_iKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_iKey;
                @_oKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_oKey;
                @_oKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_oKey;
                @_oKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_oKey;
                @_pKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_pKey;
                @_pKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_pKey;
                @_pKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_pKey;
                @_ueKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ueKey;
                @_ueKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ueKey;
                @_ueKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ueKey;
                @_ue2Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ue2Key;
                @_ue2Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ue2Key;
                @_ue2Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_ue2Key;
                @Enter.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEnter;
                @Enter.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEnter;
                @Enter.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.OnEnter;
                @_aKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aKey;
                @_aKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aKey;
                @_aKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aKey;
                @_sKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_sKey;
                @_sKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_sKey;
                @_sKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_sKey;
                @_dKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dKey;
                @_dKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dKey;
                @_dKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dKey;
                @_fKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_fKey;
                @_fKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_fKey;
                @_fKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_fKey;
                @_gKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_gKey;
                @_gKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_gKey;
                @_gKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_gKey;
                @_hKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hKey;
                @_hKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hKey;
                @_hKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hKey;
                @_jKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_jKey;
                @_jKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_jKey;
                @_jKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_jKey;
                @_kKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_kKey;
                @_kKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_kKey;
                @_kKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_kKey;
                @_lKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_lKey;
                @_lKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_lKey;
                @_lKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_lKey;
                @_semicolonKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_semicolonKey;
                @_semicolonKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_semicolonKey;
                @_semicolonKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_semicolonKey;
                @_aposKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aposKey;
                @_aposKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aposKey;
                @_aposKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_aposKey;
                @_hashKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hashKey;
                @_hashKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hashKey;
                @_hashKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_hashKey;
                @_backslashKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_backslashKey;
                @_backslashKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_backslashKey;
                @_backslashKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_backslashKey;
                @_zKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_zKey;
                @_zKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_zKey;
                @_zKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_zKey;
                @_xKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_xKey;
                @_xKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_xKey;
                @_xKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_xKey;
                @_cKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_cKey;
                @_cKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_cKey;
                @_cKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_cKey;
                @_vKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_vKey;
                @_vKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_vKey;
                @_vKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_vKey;
                @_bKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_bKey;
                @_bKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_bKey;
                @_bKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_bKey;
                @_nKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_nKey;
                @_nKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_nKey;
                @_nKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_nKey;
                @_mKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_mKey;
                @_mKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_mKey;
                @_mKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_mKey;
                @_colonKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_colonKey;
                @_colonKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_colonKey;
                @_colonKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_colonKey;
                @_dotKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dotKey;
                @_dotKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dotKey;
                @_dotKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_dotKey;
                @_slashKey.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_slashKey;
                @_slashKey.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_slashKey;
                @_slashKey.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_slashKey;
                @_0Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_0Key;
                @_0Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_0Key;
                @_0Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_0Key;
                @_1Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_1Key;
                @_1Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_1Key;
                @_1Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_1Key;
                @_2Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_2Key;
                @_2Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_2Key;
                @_2Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_2Key;
                @_3Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_3Key;
                @_3Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_3Key;
                @_3Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_3Key;
                @_4Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_4Key;
                @_4Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_4Key;
                @_4Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_4Key;
                @_5Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_5Key;
                @_5Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_5Key;
                @_5Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_5Key;
                @_6Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_6Key;
                @_6Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_6Key;
                @_6Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_6Key;
                @_7Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_7Key;
                @_7Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_7Key;
                @_7Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_7Key;
                @_8Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_8Key;
                @_8Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_8Key;
                @_8Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_8Key;
                @_9Key.started -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_9Key;
                @_9Key.performed -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_9Key;
                @_9Key.canceled -= m_Wrapper.m_CrosshairActionsCallbackInterface.On_9Key;
            }
            m_Wrapper.m_CrosshairActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveLeft.started += instance.OnMoveLeft;
                @MoveLeft.performed += instance.OnMoveLeft;
                @MoveLeft.canceled += instance.OnMoveLeft;
                @MoveRight.started += instance.OnMoveRight;
                @MoveRight.performed += instance.OnMoveRight;
                @MoveRight.canceled += instance.OnMoveRight;
                @MoveUp.started += instance.OnMoveUp;
                @MoveUp.performed += instance.OnMoveUp;
                @MoveUp.canceled += instance.OnMoveUp;
                @MoveDown.started += instance.OnMoveDown;
                @MoveDown.performed += instance.OnMoveDown;
                @MoveDown.canceled += instance.OnMoveDown;
                @Space.started += instance.OnSpace;
                @Space.performed += instance.OnSpace;
                @Space.canceled += instance.OnSpace;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
                @_qKey.started += instance.On_qKey;
                @_qKey.performed += instance.On_qKey;
                @_qKey.canceled += instance.On_qKey;
                @_wKey.started += instance.On_wKey;
                @_wKey.performed += instance.On_wKey;
                @_wKey.canceled += instance.On_wKey;
                @_eKey.started += instance.On_eKey;
                @_eKey.performed += instance.On_eKey;
                @_eKey.canceled += instance.On_eKey;
                @_rKey.started += instance.On_rKey;
                @_rKey.performed += instance.On_rKey;
                @_rKey.canceled += instance.On_rKey;
                @_tKey.started += instance.On_tKey;
                @_tKey.performed += instance.On_tKey;
                @_tKey.canceled += instance.On_tKey;
                @_yKez.started += instance.On_yKez;
                @_yKez.performed += instance.On_yKez;
                @_yKez.canceled += instance.On_yKez;
                @_uKey.started += instance.On_uKey;
                @_uKey.performed += instance.On_uKey;
                @_uKey.canceled += instance.On_uKey;
                @_iKey.started += instance.On_iKey;
                @_iKey.performed += instance.On_iKey;
                @_iKey.canceled += instance.On_iKey;
                @_oKey.started += instance.On_oKey;
                @_oKey.performed += instance.On_oKey;
                @_oKey.canceled += instance.On_oKey;
                @_pKey.started += instance.On_pKey;
                @_pKey.performed += instance.On_pKey;
                @_pKey.canceled += instance.On_pKey;
                @_ueKey.started += instance.On_ueKey;
                @_ueKey.performed += instance.On_ueKey;
                @_ueKey.canceled += instance.On_ueKey;
                @_ue2Key.started += instance.On_ue2Key;
                @_ue2Key.performed += instance.On_ue2Key;
                @_ue2Key.canceled += instance.On_ue2Key;
                @Enter.started += instance.OnEnter;
                @Enter.performed += instance.OnEnter;
                @Enter.canceled += instance.OnEnter;
                @_aKey.started += instance.On_aKey;
                @_aKey.performed += instance.On_aKey;
                @_aKey.canceled += instance.On_aKey;
                @_sKey.started += instance.On_sKey;
                @_sKey.performed += instance.On_sKey;
                @_sKey.canceled += instance.On_sKey;
                @_dKey.started += instance.On_dKey;
                @_dKey.performed += instance.On_dKey;
                @_dKey.canceled += instance.On_dKey;
                @_fKey.started += instance.On_fKey;
                @_fKey.performed += instance.On_fKey;
                @_fKey.canceled += instance.On_fKey;
                @_gKey.started += instance.On_gKey;
                @_gKey.performed += instance.On_gKey;
                @_gKey.canceled += instance.On_gKey;
                @_hKey.started += instance.On_hKey;
                @_hKey.performed += instance.On_hKey;
                @_hKey.canceled += instance.On_hKey;
                @_jKey.started += instance.On_jKey;
                @_jKey.performed += instance.On_jKey;
                @_jKey.canceled += instance.On_jKey;
                @_kKey.started += instance.On_kKey;
                @_kKey.performed += instance.On_kKey;
                @_kKey.canceled += instance.On_kKey;
                @_lKey.started += instance.On_lKey;
                @_lKey.performed += instance.On_lKey;
                @_lKey.canceled += instance.On_lKey;
                @_semicolonKey.started += instance.On_semicolonKey;
                @_semicolonKey.performed += instance.On_semicolonKey;
                @_semicolonKey.canceled += instance.On_semicolonKey;
                @_aposKey.started += instance.On_aposKey;
                @_aposKey.performed += instance.On_aposKey;
                @_aposKey.canceled += instance.On_aposKey;
                @_hashKey.started += instance.On_hashKey;
                @_hashKey.performed += instance.On_hashKey;
                @_hashKey.canceled += instance.On_hashKey;
                @_backslashKey.started += instance.On_backslashKey;
                @_backslashKey.performed += instance.On_backslashKey;
                @_backslashKey.canceled += instance.On_backslashKey;
                @_zKey.started += instance.On_zKey;
                @_zKey.performed += instance.On_zKey;
                @_zKey.canceled += instance.On_zKey;
                @_xKey.started += instance.On_xKey;
                @_xKey.performed += instance.On_xKey;
                @_xKey.canceled += instance.On_xKey;
                @_cKey.started += instance.On_cKey;
                @_cKey.performed += instance.On_cKey;
                @_cKey.canceled += instance.On_cKey;
                @_vKey.started += instance.On_vKey;
                @_vKey.performed += instance.On_vKey;
                @_vKey.canceled += instance.On_vKey;
                @_bKey.started += instance.On_bKey;
                @_bKey.performed += instance.On_bKey;
                @_bKey.canceled += instance.On_bKey;
                @_nKey.started += instance.On_nKey;
                @_nKey.performed += instance.On_nKey;
                @_nKey.canceled += instance.On_nKey;
                @_mKey.started += instance.On_mKey;
                @_mKey.performed += instance.On_mKey;
                @_mKey.canceled += instance.On_mKey;
                @_colonKey.started += instance.On_colonKey;
                @_colonKey.performed += instance.On_colonKey;
                @_colonKey.canceled += instance.On_colonKey;
                @_dotKey.started += instance.On_dotKey;
                @_dotKey.performed += instance.On_dotKey;
                @_dotKey.canceled += instance.On_dotKey;
                @_slashKey.started += instance.On_slashKey;
                @_slashKey.performed += instance.On_slashKey;
                @_slashKey.canceled += instance.On_slashKey;
                @_0Key.started += instance.On_0Key;
                @_0Key.performed += instance.On_0Key;
                @_0Key.canceled += instance.On_0Key;
                @_1Key.started += instance.On_1Key;
                @_1Key.performed += instance.On_1Key;
                @_1Key.canceled += instance.On_1Key;
                @_2Key.started += instance.On_2Key;
                @_2Key.performed += instance.On_2Key;
                @_2Key.canceled += instance.On_2Key;
                @_3Key.started += instance.On_3Key;
                @_3Key.performed += instance.On_3Key;
                @_3Key.canceled += instance.On_3Key;
                @_4Key.started += instance.On_4Key;
                @_4Key.performed += instance.On_4Key;
                @_4Key.canceled += instance.On_4Key;
                @_5Key.started += instance.On_5Key;
                @_5Key.performed += instance.On_5Key;
                @_5Key.canceled += instance.On_5Key;
                @_6Key.started += instance.On_6Key;
                @_6Key.performed += instance.On_6Key;
                @_6Key.canceled += instance.On_6Key;
                @_7Key.started += instance.On_7Key;
                @_7Key.performed += instance.On_7Key;
                @_7Key.canceled += instance.On_7Key;
                @_8Key.started += instance.On_8Key;
                @_8Key.performed += instance.On_8Key;
                @_8Key.canceled += instance.On_8Key;
                @_9Key.started += instance.On_9Key;
                @_9Key.performed += instance.On_9Key;
                @_9Key.canceled += instance.On_9Key;
            }
        }
    }
    public CrosshairActions @Crosshair => new CrosshairActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Cancel;
    private readonly InputAction m_UI_ScrollWheel;
    private readonly InputAction m_UI_MiddleClick;
    private readonly InputAction m_UI_RightClick;
    private readonly InputAction m_UI_TrackedDevicePosition;
    private readonly InputAction m_UI_TrackedDeviceOrientation;
    private readonly InputAction m_UI_Navigate;
    private readonly InputAction m_UI_Submit;
    private readonly InputAction m_UI_Point;
    private readonly InputAction m_UI_Click;
    public struct UIActions
    {
        private @InputMaster m_Wrapper;
        public UIActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Cancel => m_Wrapper.m_UI_Cancel;
        public InputAction @ScrollWheel => m_Wrapper.m_UI_ScrollWheel;
        public InputAction @MiddleClick => m_Wrapper.m_UI_MiddleClick;
        public InputAction @RightClick => m_Wrapper.m_UI_RightClick;
        public InputAction @TrackedDevicePosition => m_Wrapper.m_UI_TrackedDevicePosition;
        public InputAction @TrackedDeviceOrientation => m_Wrapper.m_UI_TrackedDeviceOrientation;
        public InputAction @Navigate => m_Wrapper.m_UI_Navigate;
        public InputAction @Submit => m_Wrapper.m_UI_Submit;
        public InputAction @Point => m_Wrapper.m_UI_Point;
        public InputAction @Click => m_Wrapper.m_UI_Click;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @Cancel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnCancel;
                @ScrollWheel.started -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @ScrollWheel.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnScrollWheel;
                @MiddleClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @MiddleClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnMiddleClick;
                @RightClick.started -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @RightClick.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnRightClick;
                @TrackedDevicePosition.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnTrackedDeviceOrientation;
                @Navigate.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNavigate;
                @Submit.started -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnSubmit;
                @Point.started -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Point.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnPoint;
                @Click.started -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
                @Click.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnClick;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @ScrollWheel.started += instance.OnScrollWheel;
                @ScrollWheel.performed += instance.OnScrollWheel;
                @ScrollWheel.canceled += instance.OnScrollWheel;
                @MiddleClick.started += instance.OnMiddleClick;
                @MiddleClick.performed += instance.OnMiddleClick;
                @MiddleClick.canceled += instance.OnMiddleClick;
                @RightClick.started += instance.OnRightClick;
                @RightClick.performed += instance.OnRightClick;
                @RightClick.canceled += instance.OnRightClick;
                @TrackedDevicePosition.started += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.performed += instance.OnTrackedDevicePosition;
                @TrackedDevicePosition.canceled += instance.OnTrackedDevicePosition;
                @TrackedDeviceOrientation.started += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.performed += instance.OnTrackedDeviceOrientation;
                @TrackedDeviceOrientation.canceled += instance.OnTrackedDeviceOrientation;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Point.started += instance.OnPoint;
                @Point.performed += instance.OnPoint;
                @Point.canceled += instance.OnPoint;
                @Click.started += instance.OnClick;
                @Click.performed += instance.OnClick;
                @Click.canceled += instance.OnClick;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_FirstControlSchemeSchemeIndex = -1;
    public InputControlScheme FirstControlSchemeScheme
    {
        get
        {
            if (m_FirstControlSchemeSchemeIndex == -1) m_FirstControlSchemeSchemeIndex = asset.FindControlSchemeIndex("FirstControlScheme");
            return asset.controlSchemes[m_FirstControlSchemeSchemeIndex];
        }
    }
    public interface ICrosshairActions
    {
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnSpace(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
        void On_qKey(InputAction.CallbackContext context);
        void On_wKey(InputAction.CallbackContext context);
        void On_eKey(InputAction.CallbackContext context);
        void On_rKey(InputAction.CallbackContext context);
        void On_tKey(InputAction.CallbackContext context);
        void On_yKez(InputAction.CallbackContext context);
        void On_uKey(InputAction.CallbackContext context);
        void On_iKey(InputAction.CallbackContext context);
        void On_oKey(InputAction.CallbackContext context);
        void On_pKey(InputAction.CallbackContext context);
        void On_ueKey(InputAction.CallbackContext context);
        void On_ue2Key(InputAction.CallbackContext context);
        void OnEnter(InputAction.CallbackContext context);
        void On_aKey(InputAction.CallbackContext context);
        void On_sKey(InputAction.CallbackContext context);
        void On_dKey(InputAction.CallbackContext context);
        void On_fKey(InputAction.CallbackContext context);
        void On_gKey(InputAction.CallbackContext context);
        void On_hKey(InputAction.CallbackContext context);
        void On_jKey(InputAction.CallbackContext context);
        void On_kKey(InputAction.CallbackContext context);
        void On_lKey(InputAction.CallbackContext context);
        void On_semicolonKey(InputAction.CallbackContext context);
        void On_aposKey(InputAction.CallbackContext context);
        void On_hashKey(InputAction.CallbackContext context);
        void On_backslashKey(InputAction.CallbackContext context);
        void On_zKey(InputAction.CallbackContext context);
        void On_xKey(InputAction.CallbackContext context);
        void On_cKey(InputAction.CallbackContext context);
        void On_vKey(InputAction.CallbackContext context);
        void On_bKey(InputAction.CallbackContext context);
        void On_nKey(InputAction.CallbackContext context);
        void On_mKey(InputAction.CallbackContext context);
        void On_colonKey(InputAction.CallbackContext context);
        void On_dotKey(InputAction.CallbackContext context);
        void On_slashKey(InputAction.CallbackContext context);
        void On_0Key(InputAction.CallbackContext context);
        void On_1Key(InputAction.CallbackContext context);
        void On_2Key(InputAction.CallbackContext context);
        void On_3Key(InputAction.CallbackContext context);
        void On_4Key(InputAction.CallbackContext context);
        void On_5Key(InputAction.CallbackContext context);
        void On_6Key(InputAction.CallbackContext context);
        void On_7Key(InputAction.CallbackContext context);
        void On_8Key(InputAction.CallbackContext context);
        void On_9Key(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnCancel(InputAction.CallbackContext context);
        void OnScrollWheel(InputAction.CallbackContext context);
        void OnMiddleClick(InputAction.CallbackContext context);
        void OnRightClick(InputAction.CallbackContext context);
        void OnTrackedDevicePosition(InputAction.CallbackContext context);
        void OnTrackedDeviceOrientation(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnPoint(InputAction.CallbackContext context);
        void OnClick(InputAction.CallbackContext context);
    }
}
