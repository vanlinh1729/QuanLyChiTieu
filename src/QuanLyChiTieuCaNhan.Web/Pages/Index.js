$(function () {
    abp.log.debug('Index.js initialized!');

    var l = abp.localization.getResource('QuanLyChiTieuCaNhan');

    // Load data asynchronously using Ajax
    function loadData() {
        $.ajax({
            url: 'https://localhost:44377/api/app/wallet/wallet-name',
            type: 'GET',
            headers: {
                'accept': 'application/json',
                'RequestVerificationToken': 'your-token-here',
                'X-Requested-With': 'XMLHttpRequest'
            },
            success: function (responseData) {
                displayData(responseData);
            },
            error: function (error) {
                console.error('Error loading data:', error);
            }
        });
    }

    // Display data as buttons in listWallet
    function displayData(responseData) {
        var listWalletContainer = $('#listWallet');

        responseData.forEach(function (data) {
            // Create a button element for each data item
            var button = $('<button/>', {
                text: ' '+data.walletName,
                'data-id': data.id,
                class: 'btn btn-outline-primary btn-lg col-md-2 bold wallet-button' // Added btn-lg class
            });

            // Add icon to the button
            var icon = $('<i/>', {
                class: 'fas fa-wallet mr-2 fa-lg' // Added fa-lg class for larger icon
            });
            button.prepend(icon);

            // Add click event handler if needed
            button.on('click', function () {
                // Handle button click
                console.log('Button clicked. ID: ' + data.id);
            });

            // Append the button to the listWallet container
            listWalletContainer.append(button);
        });
    }
    // Call the loadData function to initiate the process
    loadData();
    
    $("#NewWalletButton").on("click", function () {
        var name = $("#walletNameInput").val();
        if(name != ''){
            $.ajax({
                url: 'https://localhost:44377/api/app/wallet/wallet-with-name',
                type: 'POST',
                data: {walletName: name}
                ,
                success: function () {
                    location.reload();
                    abp.notify.info(l('SuccessfullyCreateWallet'));
                },
                error: function (error) {
                    console.error('Error create wallet with name:', error);
                    abp.notify.error(l('CreateWalletFailed'));

                }
            });

        }
        else {
            abp.notify.error(l('WalletNameCannotBeEmpty!'));
        }
    })
    
    
});
