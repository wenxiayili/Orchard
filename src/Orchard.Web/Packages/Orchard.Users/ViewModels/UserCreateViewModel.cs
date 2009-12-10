using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Orchard.Models.ViewModels;
using Orchard.Mvc.ViewModels;

namespace Orchard.Users.ViewModels {
    public class UserCreateViewModel : AdminViewModel {
        [Required]
        public string UserName { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public ItemEditorModel EditorModel { get; set; }
    }
}